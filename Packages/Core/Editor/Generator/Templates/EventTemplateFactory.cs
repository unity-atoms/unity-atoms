using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEditor;

namespace UnityAtoms.Editor
{
    [InitializeOnLoad]
    public static class EventTemplateFactory
    {
        public const string atomName = "Event";

        static EventTemplateFactory()
        {
            AtomGenerator.populators += AtomPopulator;
            AtomGenerator.evaluators += AtomEvaluator;
        }

        private static void AtomPopulator(Type generatedType, Dictionary<string, Template> templates)
        {
            var atomTemplate = GetTemplate(generatedType);
            templates.Add(atomName, atomTemplate);

            var atomPairTemplate = PairTemplateFactory.GetTemplate(generatedType, GetTemplate);
            templates.Add($"{atomName} {PairTemplateFactory.atomName}", atomPairTemplate);
        }

        private static void AtomEvaluator(Type generatedType, ReadOnlyDictionary<string, Generator.Solver> solvers)
        {
            if (generatedType == typeof(Void)
                && solvers.TryGetValue(atomName, out Generator.Solver solver))
            {
                solver.template.body +=
$@"
        public override void Raise()
        {{
            Raise(new Void());
        }}
    ";
            }
        }

        public static Template GetTemplate(Type type) => AtomTemplateFactory.GetAssetTemplate(typeof(AtomEvent<>), type, atomName, "atom-icon-cherry");
    }
}
