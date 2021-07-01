using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Generator that can be populated by Templates to generate scripts from. Used by the `GeneratorEditor`.
    /// </summary>
    public abstract class Generator : ScriptableObject, ISerializationCallbackReceiver
    {
#pragma warning disable CS0414 // Value is never used warning, however the value is used inside the GeneratorEditor.
        [SerializeField] [HideInInspector] private bool safeSearch = true;
#pragma warning restore CS0414

        public Type generatedType;
        public string @namespace = nameof(UnityAtoms);

        protected SortedList<string, Solver> solvers = new SortedList<string, Solver>();

        [Serializable]
        public class Solver
        {
            public Template template;
            public bool option;
            public MonoScript script;

            internal Solver(Template template)
            {
                this.template = template;
            }
        }

        #region Serialization
        [SerializeField] private string _assemblyQualifiedName;
        [SerializeField] private List<string> _keys;
        [SerializeField] private List<Template> _templates;
        [SerializeField] private List<bool> _options;
        [SerializeField] private List<MonoScript> _scripts;

        [NonSerialized] private bool _solversPopulated = false;

        public delegate void Populator(Type generatedType, Dictionary<string, Template> templates);
        public event Populator populator;

        public delegate void Evaluator(Type generatedType, ReadOnlyDictionary<string, Solver> solvers);
        public event Evaluator evaluator;

        public void OnBeforeSerialize()
        {
            _assemblyQualifiedName = generatedType?.AssemblyQualifiedName;

            if (!_solversPopulated && generatedType != null)
            {
                var keyTemplatePairs = new Dictionary<string, Template>();
                populator?.Invoke(generatedType, keyTemplatePairs);

                foreach (var keyTemplatePair in keyTemplatePairs)
                {
                    var solver = new Solver(keyTemplatePair.Value);
                    solver.template.@namespace = @namespace;

                    var keyIndex = _keys.IndexOf(keyTemplatePair.Key);
                    if (keyIndex != -1)
                    {
                        solver.option = _options[keyIndex];
                        solver.script = _scripts[keyIndex];
                    }

                    solvers.Add(keyTemplatePair.Key, solver);
                }

                var readOnlySolvers = new ReadOnlyDictionary<string, Solver>(solvers);
                evaluator?.Invoke(generatedType, readOnlySolvers);
                solvers = new SortedList<string, Solver>(readOnlySolvers);

            }
            _solversPopulated = true;

            _keys = new List<string>(solvers.Keys);

            _templates = new List<Template>(solvers.Values.Count);
            _options = new List<bool>(solvers.Values.Count);
            _scripts = new List<MonoScript>(solvers.Values.Count);
            for (int i = 0; i < solvers.Values.Count; i++)
            {
                var solver = solvers.Values[i];

                _templates.Add(solver.template);
                _options.Add(solver.option);
                _scripts.Add(solver.script);
            }
        }

        public void OnAfterDeserialize()
        {
            generatedType = Type.GetType(_assemblyQualifiedName ?? string.Empty);

            solvers.Clear();
            _solversPopulated = false;
        }
        #endregion

        #region Generation
        /// <summary>
        /// Generate scripts inside the generators directory from the generators templates.
        /// </summary>
        public void Generate()
        {
            var assetPaths = new string[solvers.Values.Count];

            try
            {
                AssetDatabase.StartAssetEditing();

                for (int i = 0; i < solvers.Values.Count; i++)
                {
                    var solver = solvers.Values[i];

                    if (solver.option)
                    {
                        var directory = solver.script
                            ? AssetDatabase.GetAssetPath(solver.script)
                            : AssetDatabase.GetAssetPath(this);
                        directory = Path.GetDirectoryName(directory);

                        Generate(directory, solver.template);
                        assetPaths[i] = $"{directory}/{solver.template.className}.cs";
                    }
                }
            }
            finally
            {
                AssetDatabase.StopAssetEditing();
                AssetDatabase.SaveAssets();
            }

            for (int i = 0; i < solvers.Values.Count; i++)
            {
                var solver = solvers.Values[i];

                if (solver.option)
                {
                    solvers.Values[i].script = AssetDatabase.LoadAssetAtPath<MonoScript>(assetPaths[i]);
                }
            }
        }

        /// <summary>
        /// Generate scripts inside the directory from the input templates.
        /// </summary>
        /// <param name="directory">The folder path where the scripts are going to be written to.</param>
        /// <param name="template">The template to generate the script from.</param>
        /// <param name="templates">The templates to generate the scripts from.</param>
        public static MonoScript[] Generate(string directory, params Template[] templates)
        {
            var assetPaths = new string[templates.Length];

            try
            {
                AssetDatabase.StartAssetEditing();

                for (int i = 0; i < templates.Length; i++)
                {
                    var template = templates[i];
                    Generate(directory, template);

                    assetPaths[i] = $"{directory}/{template.className}.cs";
                }
            }
            finally
            {
                AssetDatabase.StopAssetEditing();
                AssetDatabase.SaveAssets();
            }

            var monoScripts = new MonoScript[assetPaths.Length];
            for (int i = 0; i < assetPaths.Length; i++)
            {
                var assetPath = assetPaths[i];
                monoScripts[i] = AssetDatabase.LoadAssetAtPath<MonoScript>(assetPath);
            }

            return monoScripts;
        }

        /// <summary>
        /// Generate scripts inside the directory from the input templates.
        /// </summary>
        /// <param name="directory">The folder path where the scripts are going to be written to.</param>
        /// <param name="template">The template to generate the script from.</param>
        /// <param name="templates">The templates to generate the scripts from.</param>
        public static MonoScript Generate(string directory, Template template)
        {
            var content = template.Resolve();
            var path = $"{directory}/{template.className}.cs";

            File.WriteAllText(path, content);
            AssetDatabase.ImportAsset(path);

            return AssetDatabase.LoadAssetAtPath<MonoScript>(path);
        }
        #endregion

        #region Template Methods
        [Obsolete("This methods makes the legacy generator methods work with types. It is strongly recommended however to use the Generate methods instead.", false)]
        public static string[] GetTemplatePaths()
        {
            var templateSearchPath = Runtime.IsUnityAtomsRepo ?
                Directory.GetParent(Application.dataPath).Parent.FullName : // "Packages"
                Directory.GetParent(Application.dataPath).FullName;

            return Directory.GetFiles(templateSearchPath, "UA_Template*.txt", SearchOption.AllDirectories);
        }

        [Obsolete("This methods makes the legacy generator methods work with types. It is strongly recommended however to use the Generate methods instead.", false)]
        public static Dictionary<string, string> CreateTemplateVariablesMap(Type type, bool asPair, string withNamespace = default)
        {
            var typeName = type.FullName.Replace('+', '.'); // This accounts for nested types.
            var displayNameNoPair = type.Name.Capitalize();
            var displayName = displayNameNoPair;

            if (asPair)
            {
                typeName = $"Pair<{typeName}>";
                displayName += "Pair";
            }

            // Add Types.
            var templateVariables = new Dictionary<string, string>()
            {
                { "VALUE_TYPE", typeName },
                { "VALUE_TYPE_NAME", displayName },
                { "VALUE_TYPE_NAME_NO_PAIR", displayNameNoPair }
            };

            // Add Namespaces if applicable.
            var typeNamespace = type.Namespace;
            if (!string.IsNullOrEmpty(typeNamespace))
            {
                templateVariables.Add("TYPE_NAMESPACE", typeNamespace);
            }
            if (!string.IsNullOrEmpty(withNamespace))
            {
                templateVariables.Add("SUB_UA_NAMESPACE", withNamespace);
            }

            return templateVariables;
        }

        [Obsolete("This methods makes the legacy generator methods work with types. It is strongly recommended however to use the Generate methods instead.", false)]
        public static List<string> CreateTemplateConditions(Type type, string withNamespace = default)
        {
            var typeName = type.FullName.Replace('+', '.'); // This accounts for nested types.

            // Add type.
            var templateConditions = new List<string>
            {
                $"TYPE_IS_{typeName.ToUpper()}"
            };

            // Add Type code condition if applicable.
            if (type.IsNumeric())
            {
                templateConditions.Add("IS_NUMERIC");
            }
            if (type.IsVector())
            {
                templateConditions.Add("IS_VECTOR");
            }

            // Add Equatable condition if applicable.
            var isTypeEquatable = type.GetInterfaces().Contains(typeof(IEquatable<>).MakeGenericType(type));
            if (isTypeEquatable)
            {
                templateConditions.Add("EQUATABLE");
            }

            // Add Namespace conditions if applicable.
            var typeNamespace = type.Namespace;
            if (!string.IsNullOrEmpty(typeNamespace))
            {
                templateConditions.Add("TYPE_HAS_NAMESPACE");
            }
            if (!string.IsNullOrEmpty(withNamespace))
            {
                templateConditions.Add("HAS_SUB_UA_NAMESPACE");
            }

            return templateConditions;
        }
        #endregion

        #region Deprecated
        [Obsolete("Use the same method with a Type parameter instead.", false)]
        public static List<string> CreateTemplateConditions(bool isValueTypeEquatable, string valueTypeNamespace, string subUnityAtomsNamespace, string valueType)
        {
            var templateConditions = new List<string>();
            templateConditions.Add("TYPE_IS_" + valueType.ToUpper());
            if (valueType == "int" || valueType == "float") { templateConditions.Add("IS_NUMERIC"); }
            if (valueType == "Vector2" || valueType == "Vector3") { templateConditions.Add("IS_VECTOR"); }
            if (isValueTypeEquatable) { templateConditions.Add("EQUATABLE"); }
            if (!string.IsNullOrEmpty(valueTypeNamespace)) { templateConditions.Add("TYPE_HAS_NAMESPACE"); }
            if (!string.IsNullOrEmpty(subUnityAtomsNamespace)) { templateConditions.Add("HAS_SUB_UA_NAMESPACE"); }

            return templateConditions;
        }

        [Obsolete("Use the same method with a Type parameter instead.", false)]
        public static Dictionary<string, string> CreateTemplateVariablesMap(string valueType, string valueTypeNamespace, string subUnityAtomsNamespace)
        {
            var templateVariables = new Dictionary<string, string>() {
                { "VALUE_TYPE_NAME", valueType.Replace('.', '_').Capitalize() },
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
        [Obsolete("Use the same method with a Type parameter instead.", false)]
        public static void Generate(AtomRecipe atomReceipe, string baseWritePath, string[] templatePaths, List<string> templateConditions, Dictionary<string, string> templateVariables)
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
        [Obsolete("Outdated method.", false)]
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
                    var usingStr = $"using {kvp.Key};";
                    contentCopy = contentCopy.Remove(contentCopy.IndexOf(usingStr), usingStr.Length + 1);
                }
            }

            return contentCopy;
        }
        #endregion
    }
}
