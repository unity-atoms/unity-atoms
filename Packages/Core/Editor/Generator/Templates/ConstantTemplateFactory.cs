using System;
using System.Collections.Generic;
using UnityEditor;

namespace UnityAtoms.Editor
{
    [InitializeOnLoad]
    public static class ConstantTemplateFactory
    {
        public const string atomName = "Constant";

        static ConstantTemplateFactory()
        {
            AtomGenerator.populators += AtomPopulator;
        }

        private static void AtomPopulator(Type generatedType, Dictionary<string, Template> templates)
        {
            var atomTemplate = GetTemplate(generatedType);
            templates.Add(atomName, atomTemplate);
        }

        public static Template GetTemplate(Type type) => AtomTemplateFactory.GetAssetTemplate(typeof(AtomBaseVariable<>), type, atomName, "atom-icon-teal");
    }
}
