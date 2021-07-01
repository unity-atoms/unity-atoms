using System;
using System.Collections.Generic;
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    [InitializeOnLoad]
    public static class SyncVariableInstancerToCollectionTemplateFactory
    {
        public const string atomName = "Sync Variable Instancer To Collection";

        static SyncVariableInstancerToCollectionTemplateFactory()
        {
            AtomGenerator.populators += AtomPopulator;
        }

        private static void AtomPopulator(Type generatedType, Dictionary<string, Template> templates)
        {
            var atomTemplate = GetTemplate(generatedType);
            templates.Add(atomName, atomTemplate);
        }

        public static Template GetTemplate(Type type)
        {
            var template = AtomTemplateFactory.GetComponentTemplate(typeof(SyncVariableInstancerToCollection<>), type, atomName, "atom-icon-delicate");

            var typeName = type.CSharpName().Capitalize();

            var oldClassName = template.className;
            template.className = template.className.Replace($"{typeName}Sync", $"Sync{typeName}");

            return template;
        }
    }
}

