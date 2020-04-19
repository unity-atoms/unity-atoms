#if UNITY_2018_4_OR_NEWER
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Generator that generates new Atom types based on the input data. Used by the `GeneratorEditor`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    internal static class Generator
    {
        public static string[] GetTemplatePaths()
        {
            var templateSearchPath = Runtime.IsUnityAtomsRepo ?
                Directory.GetParent(Application.dataPath).Parent.FullName : // "Packages"
                Directory.GetParent(Application.dataPath).FullName;

            return Directory.GetFiles(templateSearchPath, "UA_Template*.txt", SearchOption.AllDirectories);
        }

        public static List<string> CreateTemplateConditions(bool isValueTypeEquatable, string valueTypeNamespace, string subUnityAtomsNamespace)
        {
            var templateConditions = new List<string>();
            if (isValueTypeEquatable) { templateConditions.Add("EQUATABLE"); }
            if (!string.IsNullOrEmpty(valueTypeNamespace)) { templateConditions.Add("TYPE_HAS_NAMESPACE"); }
            if (!string.IsNullOrEmpty(subUnityAtomsNamespace)) { templateConditions.Add("HAS_SUB_UA_NAMESPACE"); }

            return templateConditions;
        }

        public static Dictionary<string, string> CreateTemplateVariablesMap(string valueType, string valueTypeNamespace, string subUnityAtomsNamespace)
        {
            var templateVariables = new Dictionary<string, string>() {
                { "VALUE_TYPE_NAME", valueType.Capitalize() },
                { "VALUE_TYPE", valueType },
                { "VALUE_TYPE_NAME_NO_PAIR", valueType.Contains("Pair") ? valueType.Capitalize().Remove(valueType.IndexOf("Pair")) : valueType.Capitalize() }
            };
            if (!string.IsNullOrEmpty(valueTypeNamespace)) { templateVariables.Add("TYPE_NAMESPACE", valueTypeNamespace); }
            if (!string.IsNullOrEmpty(subUnityAtomsNamespace)) { templateVariables.Add("SUB_UA_NAMESPACE", subUnityAtomsNamespace); }

            return templateVariables;
        }

        /// <summary>
        /// Generate new Atoms based on the input data.
        /// </summary>
        /// <param name="valueType">The type of Atom to generate.abstract Eg. double, byte, MyStruct, MyClass.</param>
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
        public static void Generate(AtomReceipe atomReceipe, string baseWritePath, string[] templatePaths, List<string> templateConditions, Dictionary<string, string> templateVariables)
        {
            var (atomType, valueType) = atomReceipe;

            // TODO: More validation of that the type exists / is correct.
            if (string.IsNullOrEmpty(valueType))
            {
                Debug.LogWarning($"{Runtime.Constants.LOG_PREFIX} You need to specify a value type. Aborting!");
                return;
            }
            if (string.IsNullOrEmpty(baseWritePath) || !Directory.Exists(baseWritePath))
            {
                Debug.LogWarning($"{Runtime.Constants.LOG_PREFIX} You need to specify a valid base write path. Aborting!");
                return;
            }

            Debug.Log($"{Runtime.Constants.LOG_PREFIX} Generating atom {atomType.Name} for value type {valueType}");

            List<Tuple<string, string>> filesToGenerate = new List<Tuple<string, string>>() { new Tuple<string, string>(atomType.TemplateName, atomType.RelativeFileNameAndPath) };
            if (atomType.HasDrawerTemplate) filesToGenerate.Add(new Tuple<string, string>(atomType.DrawerTemplateName, atomType.RelativeDrawerFileNameAndPath));
            if (atomType.HasEditorTemplate) filesToGenerate.Add(new Tuple<string, string>(atomType.EditorTemplateName, atomType.RelativeEditorFileNameAndPath));

            foreach (var (templateName, relativeFilePath) in filesToGenerate)
            {
                var templatePath = templatePaths.FirstOrDefault((path) => path.EndsWith(templateName));

                if (string.IsNullOrEmpty(templatePath))
                {
                    Debug.Log($"{Runtime.Constants.LOG_PREFIX} Template {templateName} for {atomType.DisplayName} not found. Skipping!");
                    return;
                }

                var resolvedRelativeFilePath = Templating.ResolveVariables(templateVariables: templateVariables, toResolve: relativeFilePath);
                var template = File.ReadAllText(templatePath);
                var filePath = Path.Combine(baseWritePath, resolvedRelativeFilePath);
                var fileDirectory = Path.GetDirectoryName(filePath);

                // Create write directory
                Directory.CreateDirectory(fileDirectory);

                // Adjust content
                var content = Templating.ResolveVariables(templateVariables: templateVariables, toResolve: template);
                content = Templating.ResolveConditionals(template: content, trueConditions: templateConditions);
                content = RemoveDuplicateNamespaces(template: content);

                // Write to file
                File.WriteAllText(filePath, content);
                AssetDatabase.ImportAsset(filePath);
            }
        }

        /// <summary>
        /// Removes duplicate namespaces, given content from a template.
        /// </summary>
        /// <param name="template">The content template to remove namespace from.</param>
        /// <returns>A copy of `content`, but without duplicate namespaces.</returns>
        private static string RemoveDuplicateNamespaces(string template)
        {
            var currentIndex = 0;
            var countNamespaces = new Dictionary<string, int>();
            while (true)
            {
                currentIndex = template.IndexOf("using ", currentIndex);
                if (currentIndex == -1) break;
                var namespaceStartIndex = currentIndex + 6;
                var namespaceEndIndex = template.IndexOf(";", namespaceStartIndex);
                var ns = template.Substring(namespaceStartIndex, namespaceEndIndex - namespaceStartIndex);
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

            var contentCopy = String.Copy(template);
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
    }
}
#endif
