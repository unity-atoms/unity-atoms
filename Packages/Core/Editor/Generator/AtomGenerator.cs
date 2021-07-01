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
                var generators = Resources.FindObjectsOfTypeAll<AtomGenerator>();
                foreach (var generator in generators)
                {
                    lock (populatorsLock)
                    {
                        generator.populator += value;
                    }
                }
            }
            remove
            {
                var generators = Resources.FindObjectsOfTypeAll<AtomGenerator>();
                foreach (var generator in generators)
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
                var generators = Resources.FindObjectsOfTypeAll<AtomGenerator>();
                foreach (var generator in generators)
                {
                    lock (evaluatorsLock)
                    {
                        generator.evaluator += value;
                    }
                }
            }
            remove
            {
                var generators = Resources.FindObjectsOfTypeAll<AtomGenerator>();
                foreach (var generator in generators)
                {
                    lock (evaluatorsLock)
                    {
                        generator.evaluator -= value;
                    }
                }
            }
        }
    }
}
