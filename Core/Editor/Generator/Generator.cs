#if UNITY_2019_1_OR_NEWER
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    internal class Generator
    {
        public void Generate(string type, string baseWritePath, bool isEquatable, List<AtomType> atomTypesToGenerate, string typeNamespace, string subUnityAtomsNamespace)
        {
            // TODO: More validation of that the type exists / is correct.
            if (string.IsNullOrEmpty(type))
            {
                Debug.LogWarning($"{Runtime.Constants.LOG_PREFIX} You need to specify a type name. Aborting!");
                return;
            }
            if (string.IsNullOrEmpty(baseWritePath))
            {
                Debug.LogWarning($"{Runtime.Constants.LOG_PREFIX} You need to specify a write path. Aborting!");
                return;
            }

            Debug.Log($"{Runtime.Constants.LOG_PREFIX} Generating " + type);

            // Create directories in path if they don't exists
            Directory.CreateDirectory(baseWritePath);

            // Recursively search for template files. TODO: Is there a better way to find and load templates?
            var templateSearchPath = Runtime.IsUnityAtomsRepo ?
                Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).FullName :
                Directory.GetParent(Application.dataPath).FullName;
            var templatePaths = Directory.GetFiles(templateSearchPath, "UA_Template*.txt", SearchOption.AllDirectories);
            var templateConditions = new List<string>();
            if (isEquatable) { templateConditions.Add("EQUATABLE"); }
            if (!string.IsNullOrEmpty(typeNamespace)) { templateConditions.Add("TYPE_HAS_NAMESPACE"); }
            if (!string.IsNullOrEmpty(subUnityAtomsNamespace)) { templateConditions.Add("HAS_SUB_UA_NAMESPACE"); }
            var capitalizedType = Capitalize(type);
            var templateVariables = new Dictionary<string, string>() { { "TYPE_NAME", capitalizedType }, { "TYPE", type } };
            if (!string.IsNullOrEmpty(typeNamespace)) { templateVariables.Add("TYPE_NAMESPACE", typeNamespace); }
            if (!string.IsNullOrEmpty(subUnityAtomsNamespace)) { templateVariables.Add("SUB_UA_NAMESPACE", subUnityAtomsNamespace); }

            foreach (var templatePath in templatePaths)
            {
                var templateNameStartIndex = templatePath.LastIndexOf(Path.DirectorySeparatorChar) + 1;
                var fileExtLength = 4;
                var templateName = templatePath.Substring(templateNameStartIndex, templatePath.Length - templateNameStartIndex - fileExtLength);
                var lastIndexOfDoubleUnderscore = templateName.LastIndexOf("__");
                var atomType = templateName.Substring(lastIndexOfDoubleUnderscore + 2);
                var capitalizedAtomType = Capitalize(atomType);
                var typeOccurrences = templateName.Substring(lastIndexOfDoubleUnderscore - 1, 1).ToInt(def: 1);

                if (ShouldSkipTemplate(atomTypesToGenerate, capitalizedAtomType, typeOccurrences))
                {
                    continue;
                }

                var template = File.ReadAllText(templatePath);

                // Create write directory
                var dirPath = ResolveDirPath(baseWritePath, capitalizedAtomType, templateName, atomType);
                Directory.CreateDirectory(dirPath);

                // Adjust content
                var content = Templating.ResolveVariables(templateVariables: templateVariables, toResolve: template);
                content = Templating.ResolveConditionals(template: content, trueConditions: templateConditions);
                content = RemoveDuplicateNamespaces(content);

                // Write to file
                var fileName = ResolveFileName(templateVariables, templateName, lastIndexOfDoubleUnderscore, capitalizedType, capitalizedAtomType, typeOccurrences);
                var filePath = Path.Combine(dirPath, fileName);
                File.WriteAllText(filePath, content);

                AssetDatabase.ImportAsset(filePath);
            }

            AssetDatabase.Refresh();
        }

        private static string RemoveDuplicateNamespaces(string content)
        {
            var currentIndex = 0;
            var countNamespaces = new Dictionary<string, int>();
            while (true)
            {
                currentIndex = content.IndexOf("using ", currentIndex);
                if (currentIndex == -1) break;
                var namespaceStartIndex = currentIndex + 6;
                var namespaceEndIndex = content.IndexOf(";", namespaceStartIndex);
                var ns = content.Substring(namespaceStartIndex, namespaceEndIndex - namespaceStartIndex);
                if (countNamespaces.ContainsKey(ns))
                {
                    countNamespaces[ns] = countNamespaces[ns] + 1;
                }
                else
                {
                    countNamespaces.Add(ns, 1);
                }
                currentIndex = namespaceEndIndex;
            }

            var contentCopy = String.Copy(content);
            foreach (var kvp in countNamespaces)
            {
                if (kvp.Value > 1)
                {
                    var usingStr = $"using {kvp.Key};\n";
                    contentCopy = contentCopy.Remove(contentCopy.IndexOf(usingStr), usingStr.Length);
                }
            }

            return contentCopy;
        }

        private static string ResolveFileName(Dictionary<string, string> templateVariables, string templateName, int lastIndexOfDoubleUnderscore, string capitalizedType, string capitalizedAtomType, int typeOccurrences)
        {
            if (templateName.Contains("Set{TYPE_NAME}VariableValue"))
            {
                return Templating.ResolveVariables(templateVariables: templateVariables, toResolve: $"{capitalizedAtomType}.cs");
            }

            string fileName;
            if (templateName.Contains("AtomDrawer"))
            {
                fileName = $"{capitalizedType.Repeat(typeOccurrences)}{capitalizedAtomType}Drawer.cs";
            }
            else if (templateName.Contains("AtomEditor"))
            {
                fileName = $"{capitalizedType.Repeat(typeOccurrences)}{capitalizedAtomType}Editor.cs";
            }
            else
            {
                fileName = $"{capitalizedType.Repeat(typeOccurrences)}{capitalizedAtomType}.cs";
            }

            return Templating.ResolveVariables(templateVariables: templateVariables, toResolve: fileName);
        }

        private static string ResolveDirPath(string baseWritePath, string capitalizedAtomType, string templateName, string atomType)
        {
            if (templateName.Contains("AtomDrawer"))
            {
                return Path.Combine(baseWritePath, "Editor", Runtime.IsUnityAtomsRepo ? "Drawers" : "AtomDrawers", $"{atomType}s");
            }
            else if (templateName.Contains("AtomEditor"))
            {
                return Path.Combine(baseWritePath, "Editor", Runtime.IsUnityAtomsRepo ? "Editors" : "AtomEditors", $"{atomType}s");
            }
            else if (capitalizedAtomType.Contains("Set{TYPE_NAME}VariableValue"))
            {
                return Path.Combine(baseWritePath, Runtime.IsUnityAtomsRepo ? "Runtime" : "", "Actions", "SetVariableValue");
            }

            return Path.Combine(baseWritePath, Runtime.IsUnityAtomsRepo ? "Runtime" : "", $"{capitalizedAtomType}s");
        }

        private static string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private static bool ShouldSkipTemplate(List<AtomType> atomTypesToGenerate, string capitalizedAtomType, int typeOccurrences)
        {
            return !atomTypesToGenerate.Exists((a) => a.Type == capitalizedAtomType && a.TypeOccurences == typeOccurrences);
        }
    }
}
#endif
