using System;
using System.Net;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public static class AtomTemplateFactory
    {
        public static Template GetTemplate(Type atomType, Type typeArgument, string atomName, string editorIconName)
        {
            atomType = atomType.MakeGenericType(typeArgument);

            var typeName = typeArgument.CSharpName().Capitalize();

            var template = new Template($"{typeName}{atomName.Remove(" ")}", atomType);
            template.attributes.Add(typeof(EditorIcon), new[] { $"\"{editorIconName}\"" });

            template.summary = $"{atomName} of type {WebUtility.HtmlEncode(typeArgument.CodeCompatibleName())}. Inherits from {WebUtility.HtmlEncode(template.baseClass.CodeCompatibleName())}.";

            return template;
        }

        public static Template GetAssetTemplate(Type atomType, Type typeArgument, string atomName, string editorIconName)
        {
            var template = GetTemplate(atomType, typeArgument, atomName, editorIconName);

            template.classModifier = ClassModifier.Sealed;
            template.attributes.Add(typeof(CreateAssetMenuAttribute), new[] { $"fileName = \"{template.className}\"", $"menuName = \"Atoms/{template.className.Remove(atomName.Remove(" "))}/{atomName}\"" });

            return template;
        }

        public static Template GetComponentTemplate(Type atomType, Type typeArgument, string atomName, string editorIconName)
        {
            var template = GetTemplate(atomType, typeArgument, atomName, editorIconName);

            template.attributes.Add(typeof(AddComponentMenu), new[] { $"\"Atoms/{template.className.Remove(atomName.Remove(" "))}/{atomName}\"" });

            return template;
        }
    }
}
