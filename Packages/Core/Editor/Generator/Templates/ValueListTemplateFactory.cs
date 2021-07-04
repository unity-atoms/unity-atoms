using System;
using UnityEditor;

namespace UnityAtoms.Editor
{
    [InitializeOnLoad]
    public static class ValueListTemplateFactory
    {
        public const string atomName = "Value List";

        static ValueListTemplateFactory()
        {
            AtomGenerator.populators += AtomPopulator;
        }

        private static void AtomPopulator(Type generatedType, System.Collections.Generic.Dictionary<string, Template> templates)
        {
            var atomTemplate = GetTemplate(generatedType);
            templates.Add(atomName, atomTemplate);
        }

        public static Template GetTemplate(Type type) => AtomTemplateFactory.GetAssetTemplate(typeof(AtomValueList<>), type, atomName, "atom-icon-piglet");
    }
}
