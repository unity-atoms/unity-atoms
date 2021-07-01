using System;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public static class PairTemplateFactory
    {
        public const string atomName = "Pair";

        public static Template GetTemplate(Type type, Func<Type, Template> templateFactory)
        {
            var pairType = typeof(Pair<>).MakeGenericType(type);

            var template = templateFactory.Invoke(pairType);
            var typeName = type.CSharpName().Capitalize();
            var pairTypeName = pairType.CSharpName().Capitalize();

            template.className = template.className.Replace(pairTypeName, typeName) + atomName;

            if (template.attributes.ContainsKey(typeof(CreateAssetMenuAttribute)))
            {
                var fileName = template.attributes[typeof(CreateAssetMenuAttribute)][0];
                fileName = $"{fileName.Replace(pairTypeName, typeName)} + \"{atomName}\"";
                template.attributes[typeof(CreateAssetMenuAttribute)][0] = fileName;

                var menuName = template.attributes[typeof(CreateAssetMenuAttribute)][1];
                menuName = $"{menuName.Replace(pairTypeName, typeName)} + \" {atomName}\"";
                template.attributes[typeof(CreateAssetMenuAttribute)][1] = menuName;
            }

            if (template.attributes.ContainsKey(typeof(AddComponentMenu)))
            {
                var menuName = template.attributes[typeof(AddComponentMenu)][0];
                menuName = $"{menuName.Replace(pairTypeName, typeName)} + \" {atomName}\"";
                template.attributes[typeof(AddComponentMenu)][0] = menuName;
            }

            return template;
        }
    }
}
