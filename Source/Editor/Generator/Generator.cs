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
        public void Generate(string type, string writePath, bool isEquatable)
        {
            // TODO More validation of that the type exists / is correct.
            if (string.IsNullOrEmpty(type))
            {
                Debug.LogWarning($"{RuntimeConstants.LOG_PREFIX} You need to specify a type name. Aborting!");
                return;
            }
            if (string.IsNullOrEmpty(writePath))
            {
                Debug.LogWarning($"{RuntimeConstants.LOG_PREFIX} You need to specify a write path. Aborting!");
                return;
            }

            Debug.Log($"{RuntimeConstants.LOG_PREFIX} Generating " + type);

            // Create directories in path if they don't exists
            Directory.CreateDirectory(writePath);

            // Recursively search for template files. TODO: Is there a better way to find and load templates?
            var templateSearchPath = Environment.CurrentDirectory.Contains("unity-atoms/UnityAtomsTestsAndExamples") ?
                Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).FullName :
                Directory.GetParent(Application.dataPath).FullName;
            var templatePaths = Directory.GetFiles(templateSearchPath, "UA_Template*.txt", SearchOption.AllDirectories);
            var templateConditions = isEquatable ? new List<string>() { "EQUATABLE" } : new List<string>();

            foreach (var templatePath in templatePaths)
            {
                var template = File.ReadAllText(templatePath);

                var templateNameStartIndex = templatePath.LastIndexOf(Path.DirectorySeparatorChar) + 1;
                var fileExtLength = 4;
                var templateName = templatePath.Substring(templateNameStartIndex, templatePath.Length - templateNameStartIndex - fileExtLength);
                var lastIndexOfUnderscore = templateName.LastIndexOf("_");
                var atomType = templateName.Substring(lastIndexOfUnderscore + 1);
                var typeOccurences = templateName.Substring(lastIndexOfUnderscore - 1, 1).ToInt(def: 1);

                GenerateAtom(
                    type: type,
                    atomType: atomType,
                    template: template,
                    writePath: writePath,
                    typeOccurences: typeOccurences,
                    templateConditions: templateConditions
                );
            }

            AssetDatabase.Refresh();
        }

        private static string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        private void GenerateAtom(string type, string atomType, string template, string writePath, int typeOccurences, List<string> templateConditions = null)
        {
            // Adjust content
            var capitalizedType = Capitalize(type);
            var content = template.Replace("{TYPE_NAME}", capitalizedType).Replace("{TYPE}", type);
            content = Templating.ResolveConditionals(template: content, trueConditions: templateConditions);

            // Create directory if it doesn't exist
            var capitalizedAtomType = Capitalize(atomType);
            var dirPath = Path.Combine(writePath, $"{capitalizedAtomType}s");
            Directory.CreateDirectory(dirPath);

            // Write to file
            var fileName = $"{capitalizedType.Repeat(typeOccurences)}{capitalizedAtomType}.cs";
            var filePath = Path.Combine(dirPath, fileName);
            File.WriteAllText(filePath, content);

            AssetDatabase.ImportAsset(filePath);
        }
    }
}
#endif
