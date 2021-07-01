using System;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [InitializeOnLoad]
    public static class SetVariableValueTemplateFactory
    {
        public const string atomName = "Set Variable Value";

        static SetVariableValueTemplateFactory()
        {
            AtomGenerator.populators += AtomPopulator;
        }

        private static void AtomPopulator(Type generatedType, System.Collections.Generic.Dictionary<string, Template> templates)
        {
            var atomTemplate = GetTemplate(generatedType);
            templates.Add(atomName, atomTemplate);
        }

        public static Template GetTemplate(Type type)
        {
            var template = AtomTemplateFactory.GetAssetTemplate(typeof(SetVariableValue<>), type, atomName, "atom-icon-purple");

            var typeName = type.CSharpName().Capitalize();

            var oldClassName = template.className;
            template.className = template.className.Replace($"{typeName}Set", $"Set{typeName}");

            var fileName = template.attributes[typeof(CreateAssetMenuAttribute)][0];
            fileName = fileName.Replace(oldClassName, template.className);
            template.attributes[typeof(CreateAssetMenuAttribute)][0] = fileName;

            return template;
        }
    }
}
