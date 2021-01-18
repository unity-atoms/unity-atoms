using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(AtomGenerator))]
    public class AtomGeneratorEditor : UnityEditor.Editor
    {
        private TypeSelectorDropdown typeSelectorDropdown;

        private SerializedProperty fullQualifiedName;
        private SerializedProperty typeNamespace;
        private SerializedProperty baseType;
        private SerializedProperty generatedOptions;

        private void OnEnable()
        {
            var serializeableTypes = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                     where !assembly.IsDynamic
            // Find Properties.
            fullQualifiedName = serializedObject.FindProperty(nameof(AtomGenerator.FullQualifiedName));
            typeNamespace = serializedObject.FindProperty(nameof(AtomGenerator.Namespace));
            baseType = serializedObject.FindProperty(nameof(AtomGenerator.BaseType));
            generatedOptions = serializedObject.FindProperty(nameof(AtomGenerator.GenerationOptions));
                                     from type in assembly.GetExportedTypes()
                                     where type.IsValueType
                                        || (type.Attributes & TypeAttributes.Serializable) != 0
                                     where !type.IsGenericType
                                     where !type.IsAbstract
                                     where type != null
                                     where type.Namespace == null
                                        || (!type.Namespace.Contains("Microsoft") && !type.Namespace.Contains("UnityEditor"))
                                     select type;

            typeSelectorDropdown = new TypeSelectorDropdown(serializeableTypes, selectedType =>
            {
                serializedObject.Update();

                fullQualifiedName.stringValue = selectedType.AssemblyQualifiedName;
                typeNamespace.stringValue = selectedType.Namespace;
                baseType.stringValue = selectedType.Name;

                serializedObject.ApplyModifiedProperties();
            });
        }

        public override void OnInspectorGUI()
        {
            var rect = GUILayoutUtility.GetRect(new GUIContent("Show"), EditorStyles.toolbarButton);
            if(GUILayout.Button("Select Type"))
            {
                typeSelectorDropdown.Show(rect);
            }
            EditorGUILayout.PropertyField(fullQualifiedName);


            var options = generatedOptions.intValue;
            var scripts = (target as AtomGenerator)?.Scripts;
            for (var index = 0; index < AtomTypes.ALL_ATOM_TYPES.Count; index++)
            {
                var option = AtomTypes.ALL_ATOM_TYPES[index];

                EditorGUILayout.BeginHorizontal();

                bool b = (options & (1 << index)) == (1 << index);
                EditorGUI.BeginChangeCheck();
                b = EditorGUILayout.Toggle(AtomTypes.ALL_ATOM_TYPES[index].DisplayName, b);
                if (EditorGUI.EndChangeCheck())
                {
                    if (b)
                    {
                        options |= (1 << index);
                        // add all dependencies:
                        if (AtomTypes.DEPENDENCY_GRAPH.TryGetValue(option, out var list))
                            list.ForEach(dep => options |= (1 << AtomTypes.ALL_ATOM_TYPES.IndexOf(dep)));
                    }
                    else
                    {
                        options &= ~(1 << index);
                        // remove all depending:
                        foreach (var keyValuePair in AtomTypes.DEPENDENCY_GRAPH.Where(kv => kv.Value.Contains(option)))
                        {
                            options &= ~(1 << AtomTypes.ALL_ATOM_TYPES.IndexOf(keyValuePair.Key));
                        }
                    }
                }

                if (scripts != null && index < scripts.Count && scripts[index] != null)
                {
                    EditorGUILayout.ObjectField(scripts[index], typeof(MonoScript), false, GUILayout.Width(200));
                }
                else
                {
                    EditorGUILayout.LabelField(GUIContent.none, GUILayout.Width(200));
                }

                EditorGUILayout.EndHorizontal();
            }

            generatedOptions.intValue = options;

            serializedObject.ApplyModifiedProperties();

            if (GUILayout.Button("(Re)Generate"))
            {
                (target as AtomGenerator)?.Generate();
                AssetDatabase.SaveAssets();
            }
        }

        private struct NamespaceLevel
        {
            public Dictionary<string, NamespaceLevel> namespaceLevels;
            public IEnumerable<Type> types;

            private Dictionary<AdvancedDropdownItem, Type> idTypePairs;

            public NamespaceLevel(IEnumerable<Type> types) : this(string.Empty, types) { }
            private NamespaceLevel(string name, IEnumerable<Type> types)
            {
                var nameCharArray = name.ToCharArray();
                var typeNamespaceLevelLookup = types.ToLookup(type => !string.IsNullOrEmpty(type.Namespace?.TrimStart(nameCharArray)));

                // Populate namespaceLevels
                var namespaceTypeGroups = from type in typeNamespaceLevelLookup[true]
                                          group type by type.Namespace.TrimStart(nameCharArray).Split('.')[0] into namespaceTypeGroup
                                          orderby namespaceTypeGroup.Key
                                          select namespaceTypeGroup;
                this.namespaceLevels = namespaceTypeGroups.ToDictionary(
                    namespaceTypeGroup => namespaceTypeGroup.Key
                    , namespaceTypeGroup => new NamespaceLevel($"{name}{namespaceTypeGroup.Key}.", namespaceTypeGroup));

                // Populate types
                this.types = from type in typeNamespaceLevelLookup[false]
                                 orderby type.FullName.Substring(type.FullName.LastIndexOf('.') + 1)
                                 select type;

                // Initialize other values
                this.idTypePairs = new Dictionary<AdvancedDropdownItem, Type>();
            }

            public AdvancedDropdownItem GetDropdownItem(AdvancedDropdownItem parent)
            {
                var hasTypes = types.Any();
                if(namespaceLevels.Count > 0)
                {
                    parent.AddChild(new AdvancedDropdownItem("Namespaces") { enabled = false });
                    foreach(KeyValuePair<string, NamespaceLevel> namespaceLevel in namespaceLevels)
                    {
                        var groupItem = new AdvancedDropdownItem(namespaceLevel.Key);
                        groupItem = namespaceLevel.Value.GetDropdownItem(groupItem);

                        parent.AddChild(groupItem);
                    }

                    if(hasTypes)
                    {
                        parent.AddSeparator();
                    }
                }

                idTypePairs.Clear();
                if(hasTypes)
                {
                    parent.AddChild(new AdvancedDropdownItem("Types") { enabled = false });
                    foreach(Type type in types)
                    {
                        var name = type.FullName.Substring(type.FullName.LastIndexOf('.') + 1);
                        var dropdownItem = new AdvancedDropdownItem(name);
                        parent.AddChild(dropdownItem);

                        idTypePairs.Add(dropdownItem, type);
                    }
                }

                return parent;
            }

            // NOTE: Do not use item.id! If 2 AdvancedDropdownItems have the same name, they will generate the same id (stupid, I know). To ensure searching for a unique identifier, we use the item itself.
            public Type FindType(AdvancedDropdownItem item)
            {
                if(idTypePairs.TryGetValue(item, out var type))
                {
                    return type;
                }

                foreach(NamespaceLevel namespaceLevel in namespaceLevels.Values)
                {
                    if(namespaceLevel.TryGetType(item, out type))
                    {
                        return type;
                    }
                }

                return null;
            }

            public bool TryGetType(AdvancedDropdownItem item, out Type type)
            {
                type = FindType(item);
                return type != null;
            }
        }

        private class TypeSelectorDropdown : AdvancedDropdown
        {
            private readonly NamespaceLevel typeLevel;
            private readonly Action<Type> typeSelected;

            public TypeSelectorDropdown(IEnumerable<Type> types, Action<Type> typeSelected) : this(new AdvancedDropdownState(), types, typeSelected) { }
            public TypeSelectorDropdown(AdvancedDropdownState state, IEnumerable<Type> types, Action<Type> typeSelected) : base(state)
            {
                this.typeLevel = new NamespaceLevel(types);
                this.typeSelected = typeSelected;
            }

            protected override void ItemSelected(AdvancedDropdownItem item)
            {
                base.ItemSelected(item);
                if(item.enabled && typeLevel.TryGetType(item, out var type))
                {
                    typeSelected?.Invoke(type);
                }
            }

            protected override AdvancedDropdownItem BuildRoot()
            {
                return typeLevel.GetDropdownItem(new AdvancedDropdownItem("Serializable Types"));
            }
        }
    }
}
