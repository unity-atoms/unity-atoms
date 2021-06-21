using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [CreateAssetMenu(fileName = "AtomGenerator", menuName = "Unity Atoms/Generation/AtomGenerator", order = 0)]
    public class AtomGenerator : ScriptableObject
    {
        public static Dictionary<string, Resolver> resolvers = new Dictionary<string, Resolver>();

        public string assemblyQualifiedName;
        public string withNamespace = nameof(UnityAtoms);
        public bool[] options = Enumerable.Repeat(true, resolvers.Count).ToArray();
        public MonoScript[] scripts = new MonoScript[resolvers.Count];
        public string[] keys = resolvers.Keys.ToArray();

#pragma warning disable CS0414 // Value is never used warning, however the value is used inside the AtomGeneratorEditor.
        [SerializeField][HideInInspector] private bool safeSearch = true;
#pragma warning restore CS0414

        public void Generate()
        {
            var assetPaths = new string[resolvers.Count];
            
            try
            {
                AssetDatabase.StartAssetEditing();

                var resolvers = new Resolver[AtomGenerator.resolvers.Count];
                AtomGenerator.resolvers.Values.CopyTo(resolvers, 0);

                var type = Type.GetType(assemblyQualifiedName);
                for (int i = 0; i < options.Length; i++)
                {
                    if (options[i])
                    {
                        var resolver = resolvers[i];
                        var script = scripts[i];

                        var path = script
                            ? AssetDatabase.GetAssetPath(script)
                            : AssetDatabase.GetAssetPath(this);
                        path = Path.GetDirectoryName(path);

                        Generator.Generate(resolver, type, ref path, withNamespace);
                        assetPaths[i] = path;
                    }
                }
            }
            finally
            {
                AssetDatabase.StopAssetEditing();
            }

            for (int i = 0; i < options.Length; i++)
            {
                if(options[i])
                {
                    scripts[i] = AssetDatabase.LoadAssetAtPath<MonoScript>(assetPaths[i]);
                }
            }
        }
    }
}
