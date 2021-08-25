using System;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [CreateAssetMenu(fileName = nameof(AtomGenerator), menuName = "Atoms/Generators/Atom Generator", order = -10)]
    public class AtomGenerator : Generator
    {
        private static readonly object populatorsLock = new object();
        public static event Populator populators
        {
            add
            {
                foreach (var generator in atomGenerators)
                {
                    lock (populatorsLock)
                    {
                        generator.populator += value;
                    }
                }
            }
            remove
            {
                foreach (var generator in atomGenerators)
                {
                    lock (populatorsLock)
                    {
                        generator.populator -= value;
                    }
                }
            }
        }

        private static readonly object evaluatorsLock = new object();
        public static event Evaluator evaluators
        {
            add
            {
                foreach (var generator in atomGenerators)
                {
                    lock (evaluatorsLock)
                    {
                        generator.evaluator += value;
                    }
                }
            }
            remove
            {
                foreach (var generator in atomGenerators)
                {
                    lock (evaluatorsLock)
                    {
                        generator.evaluator -= value;
                    }
                }
            }
        }

        private static AtomGenerator[] _atomGenerators = null;
        private static AtomGenerator[] atomGenerators
        {
            get
            {
                if (_atomGenerators == null)
                {
                    var generatorGuids = AssetDatabase.FindAssets($"t:{nameof(AtomGenerator)}");
                    var generatorAssetPaths = Array.ConvertAll(generatorGuids, generatorGuid => AssetDatabase.GUIDToAssetPath(generatorGuid));
                    _atomGenerators = Array.ConvertAll(generatorAssetPaths, generatorAssetPath => AssetDatabase.LoadAssetAtPath<AtomGenerator>(generatorAssetPath));

                    // Cache the AtomGenerators for 1 Editor loop so we only have to search the project once if we call this property multiple times in the same Editor loop.
                    EditorApplication.delayCall += () => _atomGenerators = null;
                }

                return _atomGenerators;
            }
        }
    }
}
