using System;
using System.Collections.Generic;
using System.Linq;

namespace UnityAtoms.Editor
{
    public struct TemplateData
    {
        public string namespaces;
        public string withNamespace;
        public string typeName;
        public string attributes;
        public string nestedMenu;

        public string openingBrackets;
        public string closingBrackets;

        public static TemplateData Generate(Type type, out string className, string withNamespace = default)
        {
            TemplateData templateData = default;

            HashSet<string> importedNamespaces = new HashSet<string>();
            AddImportedNamespace(nameof(UnityEngine));

            className = string.Empty;
            templateData.typeName = string.Empty;
            int lastTypeNameLength;
            GenerateClassName(type, ref className);

            templateData.nestedMenu = "/" + className.Insert(lastTypeNameLength, "/").TrimEnd('/');

            if (!string.IsNullOrEmpty(withNamespace))
            {
                templateData.nestedMenu = "/" + withNamespace.Replace('.', '/') + templateData.nestedMenu;

                var specialName = $"/{nameof(UnityAtoms)}";
                var specialNameIndex = templateData.nestedMenu.IndexOf(specialName);
                if (specialNameIndex != -1)
                {
                    templateData.nestedMenu = templateData.nestedMenu.Remove(specialNameIndex, specialName.Length);
                }

                templateData.withNamespace = $"namespace {withNamespace}";

                templateData.openingBrackets = "{";
                templateData.closingBrackets = "}";
            }
            else
            {
                templateData.withNamespace = string.Empty;
            }

            foreach (var attribute in type.CustomAttributes)
            {
                AddImportedNamespace(attribute.AttributeType.Namespace);

                templateData.attributes += $"{attribute.ToString().Replace($"{attribute.AttributeType.Namespace}.", string.Empty)}\n\t";
            }

            templateData.namespaces = string.Empty;
            foreach (var importedNamespace in importedNamespaces.OrderBy(importedNamespace => importedNamespace))
            {
                templateData.namespaces += $"using {importedNamespace};\n";
            }

            return templateData;

            void AddImportedNamespace(string importedNamespace)
            {
                if (!string.IsNullOrEmpty(importedNamespace)
                    && (string.IsNullOrEmpty(templateData.withNamespace) || !templateData.withNamespace.StartsWith(importedNamespace)))
                {
                    importedNamespaces.Add(importedNamespace);
                }
            }

            void GenerateClassName(Type type, ref string className, bool comma = false)
            {
                if (comma)
                {
                    templateData.typeName += ", ";
                }

                if (!type.IsKeyword())
                {
                    AddImportedNamespace(type.Namespace);
                }

                var nameOfType = type.CSharpName().TrimEnd('1').TrimEnd('`');

                if (type.IsGenericType)
                {
                    className += nameOfType.Capitalize();
                }
                else
                {
                    className = nameOfType.Capitalize() + className;
                }

                var declaringType = type.DeclaringType;
                while (declaringType != null)
                {
                    var nameOfDeclaringType = declaringType.CSharpName().TrimEnd('1').TrimEnd('`');

                    nameOfType = $"{nameOfDeclaringType}.{nameOfType}";
                    className = nameOfDeclaringType.Capitalize() + className;

                    declaringType = declaringType.DeclaringType;
                }

                templateData.typeName += nameOfType;
                lastTypeNameLength = nameOfType.Replace(".", string.Empty).Length;

                if (type.IsGenericType)
                {
                    templateData.typeName += "<";
                    for (int i = type.GenericTypeArguments.Length - 1; i >= 0; i--)
                    {
                        var genericTypeArgument = type.GenericTypeArguments[i];
                        GenerateClassName(genericTypeArgument, ref className, i != type.GenericTypeArguments.Length - 1);
                    }
                    templateData.typeName += ">";
                }
            }
        }
    }
}

