using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [Serializable]
    public sealed class Template : ISerializationCallbackReceiver
    {
        public const string autoGeneratedWarning =
@"//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a function.
//
//     Changes to this file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------";

        public string @namespace;
        public Dictionary<Type, string[]> attributes = new Dictionary<Type, string[]>();
        public ClassModifier classModifier;
        public string className;
        public Type baseClass;
        public List<Type> interfaces = new List<Type>();
        public string body;

        public string openingBrackets => string.IsNullOrEmpty(@namespace) ? string.Empty : "{";
        public string closingBrackets => string.IsNullOrEmpty(@namespace) ? string.Empty : "}";

        #region Constructors
        public Template(string className, Type baseClass) : this(default, className, baseClass) { }
        public Template(ClassModifier classModifier, string className, Type baseClass) : this(default, classModifier, className, baseClass) { }
        public Template(string @namespace, ClassModifier classModifier, string className, Type baseClass) : this(@namespace, classModifier, className, baseClass, default) { }
        public Template(string @namespace, ClassModifier classModifier, string className, Type baseClass, string body) : this(@namespace, new Dictionary<Type, string[]>(), classModifier, className, baseClass, Enumerable.Empty<Type>(), body) { }
        public Template(string @namespace, IDictionary<Type, string[]> attributes, ClassModifier classModifier, string className, Type baseClass, IEnumerable<Type> interfaces, string body)
        {
            this.@namespace = @namespace;
            this.attributes = new Dictionary<Type, string[]>(attributes);
            this.classModifier = classModifier;
            this.className = className;
            this.baseClass = baseClass;
            this.interfaces = new List<Type>(interfaces);
            this.body = body;
        }
        #endregion

        #region Serialization
        [SerializeField] private string[] attributeAssemblyQualifiedNames;
        [SerializeField] private string[] attributeParameters;
        [SerializeField] private string baseClassAssemblyQualifiedName;
        [SerializeField] private string[] interfaceAssemblyQualifiedNames;

        public void OnBeforeSerialize()
        {
            attributeAssemblyQualifiedNames =
                (from attribute in attributes
                 select attribute.Key.AssemblyQualifiedName)
                .ToArray();

            attributeParameters =
                (from attribute in attributes
                 select string.Join(",", attribute.Value))
                .ToArray();

            baseClassAssemblyQualifiedName = baseClass?.AssemblyQualifiedName;
            interfaceAssemblyQualifiedNames =
                (from @interface in interfaces
                 select @interface.AssemblyQualifiedName)
                .ToArray();
        }

        public void OnAfterDeserialize()
        {
            attributes = new Dictionary<Type, string[]>();
            for (int i = 0; i < attributeAssemblyQualifiedNames.Length; i++)
            {
                var attributeAssemblyQualifiedName = attributeAssemblyQualifiedNames[i];
                var attributeParameterString = this.attributeParameters[i];

                var type = Type.GetType(attributeAssemblyQualifiedName);
                var attributeParameters = attributeParameterString.Split(',');

                attributes.Add(type, attributeParameters);
            }

            baseClass = Type.GetType(baseClassAssemblyQualifiedName);
            interfaces =
                (from interfaceAssemblyQualifiedName in interfaceAssemblyQualifiedNames
                 select Type.GetType(interfaceAssemblyQualifiedName))
                .ToList();
        }
        #endregion

        public string Resolve() => Resolve(this);
        public static string Resolve(Template template)
        {
            var @namespace = !string.IsNullOrEmpty(template.@namespace) ? $"namespace {template.@namespace}" : string.Empty;

            var attributes = new StringBuilder();
            foreach (var attribute in template.attributes ?? new Dictionary<Type, string[]>())
            {
                var type = attribute.Key;
                var parameters = attribute.Value;

                attributes.Append($"[{type.GenericName()}({string.Join(", ", parameters)})]\n\t");
            }

            var typeName = new StringBuilder();
            if (template.baseClass != null)
            {
                typeName.Append($", {template.baseClass.GenericName()}");
            }
            foreach (var @interface in template.interfaces ?? new List<Type>())
            {
                typeName.Append(", " + @interface.GenericName());
            }
            typeName.Replace(',', ':', 0, 1);

            string classModifier;
            switch (template.classModifier)
            {
                case ClassModifier.Abstract:
                    classModifier = "abstract ";
                    break;
                case ClassModifier.Sealed:
                    classModifier = "sealed ";
                    break;
                default:
                    classModifier = string.Empty;
                    break;
            }

            return
$@"{autoGeneratedWarning}

{@namespace}
{template.openingBrackets}
    {attributes}public {classModifier}class {template.className} {typeName}
    {{{template.body}}}
{template.closingBrackets}
";
        }
    }
}