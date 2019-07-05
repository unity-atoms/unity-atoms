using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Extensions;

namespace UnityAtoms.Editor
{
    internal class Generator
    {
        public void Generate(string type, string baseWritePath, bool isEquatable)
        {
            // TODO More validation of that the type exists / is correct.
            if (string.IsNullOrEmpty(type))
            {
                Debug.LogWarning($"{RuntimeConstants.LOG_PREFIX} You need to specify a type name. Aborting!");
                return;
            }
            if (string.IsNullOrEmpty(baseWritePath))
            {
                Debug.LogWarning($"{RuntimeConstants.LOG_PREFIX} You need to specify a write path. Aborting!");
                return;
            }

            Debug.Log($"{RuntimeConstants.LOG_PREFIX} Generating " + type);

            // Create directories in path if they don't exists
            Directory.CreateDirectory(baseWritePath);

            // Recursively search for template files. TODO: Is there a better way to find and load templates?
            var templateSearchPath = Environment.CurrentDirectory.Contains("unity-atoms/UnityAtomsTestsAndExamples") ?
                Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).FullName :
                Directory.GetParent(Application.dataPath).FullName;
            var templatePaths = Directory.GetFiles(templateSearchPath, "UA_Template*.txt", SearchOption.AllDirectories);
            var templateConditions = isEquatable ? new List<string>() { "EQUATABLE" } : new List<string>();
            var capitalizedType = Capitalize(type);
            var templateVariables = new Dictionary<string, string>() { { "TYPE_NAME", capitalizedType }, { "TYPE", type } };

            foreach (var templatePath in templatePaths)
            {
                var template = File.ReadAllText(templatePath);

                var templateNameStartIndex = templatePath.LastIndexOf(Path.DirectorySeparatorChar) + 1;
                var fileExtLength = 4;
                var templateName = templatePath.Substring(templateNameStartIndex, templatePath.Length - templateNameStartIndex - fileExtLength);
                var lastIndexOfDoubleUnderscore = templateName.LastIndexOf("__");
                var atomType = templateName.Substring(lastIndexOfDoubleUnderscore + 2);
                var capitalizedAtomType = Capitalize(atomType);

                // Create write directory
                var dirPath = ResolveDirPath(baseWritePath, capitalizedAtomType);
                Directory.CreateDirectory(dirPath);

                // Adjust content
                var content = ResolveVariables(templateVariables, template);
                content = Templating.ResolveConditionals(template: content, trueConditions: templateConditions);

                // Write to file
                var fileName = ResolveFileName(templateVariables, templateName, lastIndexOfDoubleUnderscore, capitalizedType, capitalizedAtomType);
                var filePath = Path.Combine(dirPath, fileName);
                File.WriteAllText(filePath, content);

                AssetDatabase.ImportAsset(filePath);
            }

            AssetDatabase.Refresh();
        }

        private static string ResolveFileName(Dictionary<string, string> templateVariables, string templateName, int lastIndexOfDoubleUnderscore, string capitalizedType, string capitalizedAtomType)
        {
            if (templateName.Contains("Set{TYPE_NAME}VariableValue"))
            {
                return ResolveVariables(templateVariables, $"{capitalizedAtomType}.cs");
            }
            var typeOccurrences = templateName.Substring(lastIndexOfDoubleUnderscore - 1, 1).ToInt(def: 1);
            return ResolveVariables(templateVariables, $"{capitalizedType.Repeat(typeOccurrences)}{capitalizedAtomType}.cs");
        }

        private static string ResolveDirPath(string baseWritePath, string capitalizedAtomType)
        {
            if (capitalizedAtomType.Contains("AtomDrawers"))
            {
                return Path.Combine(baseWritePath, "Editor", "AtomDrawers");
            }
            else if (capitalizedAtomType.Contains("Set{TYPE_NAME}VariableValue"))
            {
                return Path.Combine(baseWritePath, "Actions", "SetVariableValue");
            }

            return Path.Combine(baseWritePath, $"{capitalizedAtomType}s");
        }

        private static string ResolveVariables(Dictionary<string, string> templateVariables, string toResolve)
        {
            var resolvedString = toResolve;
            foreach (var kvp in templateVariables)
            {
                resolvedString = resolvedString.Replace("{" + kvp.Key + "}", kvp.Value);
            }
            return resolvedString;
        }

        private static string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
#endif
