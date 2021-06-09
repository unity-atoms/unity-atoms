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
        public string withNamespace;
        public bool[] options = Enumerable.Repeat(true, resolvers.Count).ToArray();
        public MonoScript[] scripts = new MonoScript[resolvers.Count];
        public string[] keys = resolvers.Keys.ToArray();

        [SerializeField][HideInInspector] private bool safeSearch = true;

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
                        assetPaths[i] = AssetDatabase.GetAssetPath(scripts[i]);
                        var path = Path.GetDirectoryName(assetPaths[i]);

                        Generator.Generate(type, path, resolver, withNamespace);
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
                    var assetPath = assetPaths[i];
                    scripts[i] = AssetDatabase.LoadAssetAtPath<MonoScript>(assetPath);
                }
            }
        }
    }
}
