#if UNITY_2018_4_OR_NEWER
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Generator that generates new Atom types based on the input data. Used by the `GeneratorEditor`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    internal class Generator
    {
        /// <summary>
        /// Generate new Atoms based on the input data.
        /// </summary>
        /// <param name="type">The type of Atom to generate.abstract Eg. double, byte, MyStruct, MyClass.</param>
        /// <param name="baseWritePath">Base write path (relative to the Asset folder) where the Atoms are going to be written to.</param>
        /// <param name="isEquatable">Is the `type` provided implementing `IEquatable`?</param>
        /// <param name="atomTypesToGenerate">A list of `AtomType`s to be generated.</param>
        /// <param name="typeNamespace">If the `type` provided is defined under a namespace, provide that namespace here.</param>
        /// <param name="subUnityAtomsNamespace">By default the Atoms that gets generated will be under the namespace `UnityAtoms`. If you for example like it to be under `UnityAtoms.MyNamespace` you would then enter `MyNamespace` in this field.</param>
        /// <example>
        /// <code>
        /// namespace MyNamespace
        /// {
        ///     public struct MyStruct
        ///     {
        ///         public string Text;
        ///         public int Number;
        ///     }
        /// }
        /// var generator = new Generator();
        /// generator.Generate("MyStruct", "", false, new List&lt;AtomType&gt;() { AtomTypes.ACTION }, "MyNamespace", ""); // Generates an Atom Action of type MyStruct
        /// </code>
        /// </example>
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
                Directory.GetParent(baseWritePath).FullName : // "Packages"
                Directory.GetParent(Application.dataPath).FullName;
#if UNITY_2019_1_OR_NEWER
            var templatePaths = AssetDatabase.FindAssets("UA_Template t:textasset");
#elif UNITY_2018_4_OR_NEWER
            var templatePaths = Directory.GetFiles(templateSearchPath, "UA_Template*.txt", SearchOption.AllDirectories);
#endif
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
#if UNITY_2018_4_OR_NEWER
                var localTemplatePath = AssetDatabase.GUIDToAssetPath(templatePath);
#else
                var localTemplatePath = templatePath;
#endif
                var templateNameStartIndex = localTemplatePath.LastIndexOf(Path.DirectorySeparatorChar) + 1;
                var fileExtLength = 4;
                var templateName = localTemplatePath.Substring(templateNameStartIndex, localTemplatePath.Length - templateNameStartIndex - fileExtLength);
                var lastIndexOfDoubleUnderscore = templateName.LastIndexOf("__");
                var atomType = templateName.Substring(lastIndexOfDoubleUnderscore + 2);
                var capitalizedAtomType = Capitalize(atomType); Debug.Log(localTemplatePath + " : " + templateName);
                var typeOccurrences = templateName.Substring(lastIndexOfDoubleUnderscore - 1, 1).ToInt(def: 1);

                if (ShouldSkipTemplate(atomTypesToGenerate, capitalizedAtomType, typeOccurrences))
                {
                    continue;
                }

                var template = File.ReadAllText(localTemplatePath);

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

        /// <summary>
        /// Removes duplicate namespaces, given content from a template.
        /// </summary>
        /// <param name="content">The content template to remove namespace from.</param>
        /// <returns>A copy of `content`, but without duplicate namespaces.</returns>
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

        /// <summary>
        /// Resolve file name based on input data.
        /// </summary>
        /// <param name="templateVariables">Template variables. </param>
        /// <param name="templateName">Template name.</param>
        /// <param name="lastIndexOfDoubleUnderscore">Last index of double underscore.</param>
        /// <param name="capitalizedType">Capitalized type.</param>
        /// <param name="capitalizedAtomType">Capitalized Atom type (string).</param>
        /// <param name="typeOccurrences">Number of occurrences of the type.</param>
        /// <returns>The filename to use.</returns>
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

        /// <summary>
        /// Resolves the directory path based on the input data.
        /// </summary>
        /// <param name="baseWritePath">The base write path (relative to the Assets folder).</param>
        /// <param name="capitalizedAtomType">Capitalized Atom type (string).</param>
        /// <param name="templateName">Template name.</param>
        /// <param name="atomType">Atom type.</param>
        /// <returns>The directory to use.</returns>
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

        /// <summary>
        /// Capitalize the provided string.
        /// </summary>
        /// <param name="s">The string to capitalize.</param>
        /// <returns>A capitalized version of the string provided.</returns>
        private static string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        /// <summary>
        /// Given the input data, should generation of this template be skipped.
        /// </summary>
        /// <param name="atomTypesToGenerate">List of Atom types to generate.</param>
        /// <param name="capitalizedAtomType">Capitalized Atom type (string).</param>
        /// <param name="typeOccurrences">Number of occurrences of the type.</param>
        /// <returns>If we should skip the template or not.</returns>
        private static bool ShouldSkipTemplate(List<AtomType> atomTypesToGenerate, string capitalizedAtomType, int typeOccurrences)
        {
            return !atomTypesToGenerate.Exists((a) => a.Type == capitalizedAtomType && a.TypeOccurences == typeOccurrences);
        }
    }
}
#endif
