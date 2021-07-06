using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using UnityEditor;
using UnityEditor.Compilation;
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
            public readonly Template template;
            public bool option;
            public MonoScript script;

            internal Solver(Template template)
            {
                this.template = template;
            }
        }

        protected virtual void Awake()
        {
            _solversPopulated = true;

            CompilationPipeline.RequestScriptCompilation();
        }

        #region Serialization
        [SerializeField] private string _assemblyQualifiedName;
        [SerializeField] private List<string> _keys = new List<string>();
        [SerializeField] private List<Template> _templates = new List<Template>();
        [SerializeField] private List<bool> _options = new List<bool>();
        [SerializeField] private List<MonoScript> _scripts = new List<MonoScript>();

        [NonSerialized] private bool _solversPopulated = false;

        public delegate void Populator(Type generatedType, Dictionary<string, Template> templates);
        public event Populator populator;

        public delegate void Evaluator(Type generatedType, ReadOnlyDictionary<string, Solver> solvers);
        public event Evaluator evaluator;

        public void OnBeforeSerialize()
        {
            _assemblyQualifiedName = generatedType?.AssemblyQualifiedName;

            if (!_solversPopulated)
            {
                solvers.Clear();

                if (generatedType != null)
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
            for (int i = 0; i < _keys.Count; i++)
            {
                var key = _keys[i];
                var solver = new Solver(_templates[i])
                {
                    option = _options[i],
                    script = _scripts[i],
                };

                solvers.Add(key, solver);
            }

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
    }
}
