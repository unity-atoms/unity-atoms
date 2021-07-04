using System;
using UnityEditor;

namespace UnityAtoms.Editor
{
    [InitializeOnLoad]
    public static class VariableInstancerTemplateFactory
    {
        public const string atomName = "Variable Instancer";

        static VariableInstancerTemplateFactory()
        {
            AtomGenerator.populators += AtomPopulator;
        }

        private static void AtomPopulator(Type generatedType, System.Collections.Generic.Dictionary<string, Template> templates)
        {
            var atomTemplate = GetTemplate(generatedType);
            templates.Add(atomName, atomTemplate);
        }

        public static Template GetTemplate(Type type) => AtomTemplateFactory.GetComponentTemplate(typeof(AtomVariableInstancer<>), type, atomName, "atom-icon-hotpink");
    }
}
