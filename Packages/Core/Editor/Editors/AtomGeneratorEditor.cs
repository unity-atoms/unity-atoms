using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using Assembly = System.Reflection.Assembly;
using Object = UnityEngine.Object;

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

        private static bool safeSearch = true;

        private void OnEnable()
        {
            // Find Properties.
            fullQualifiedName = serializedObject.FindProperty(nameof(AtomGenerator.FullQualifiedName));
            typeNamespace = serializedObject.FindProperty(nameof(AtomGenerator.Namespace));
            baseType = serializedObject.FindProperty(nameof(AtomGenerator.BaseType));
            generatedOptions = serializedObject.FindProperty(nameof(AtomGenerator.GenerationOptions));

            // Check if the current type is unsafe.
            var currentType = Type.GetType(fullQualifiedName.stringValue);
            if(currentType == null
                || currentType.IsSubclassOf(typeof(Object)))
            {
                safeSearch = true;
            }
            else if(!currentType.IsSerializable)
            {
                safeSearch = false;
            }
            else
            {
                var assemblies = from assemblyDefinition in CompilationPipeline.GetAssemblies(AssembliesType.Player)
                                 let assembly = Assembly.Load(assemblyDefinition.name)
                                 select assembly;
                safeSearch = assemblies.Contains(currentType.Assembly);
            }

            RefreshDropdown();
        }

        public void RefreshDropdown()
        {
            // Search Player assemblies only if safe searching, else search all assemblies.
            IEnumerable<Assembly> assemblies;
            if(safeSearch)
            {
                assemblies = from assemblyDefinition in CompilationPipeline.GetAssemblies(AssembliesType.Player)
                             let assembly = Assembly.Load(assemblyDefinition.name)
                             select assembly;
            }
            else
            {
                assemblies = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                             select assembly;
            }

            // Find all types in unity that are not generic or abstract.
            var types = from assembly in assemblies
                        where !assembly.IsDynamic
                        from type in assembly.GetExportedTypes()
                        where !type.IsGenericType
                        where !type.IsAbstract
                        select type;

            // Disregard non serializable types if safe searching.
            if(safeSearch)
            {
                types = from type in types
                        where type.IsUnitySerializable()
                        select type;
            }

            // Create a type selector dropdown that sets properties when something is selected.
            typeSelectorDropdown = new TypeSelectorDropdown(types, selectedType =>
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
            serializedObject.Update();

            // Draw our type dropdown and result.
            var buttonContent = safeSearch
                ? new GUIContent($"Select Unity Type", $"Select from all Unity compatible types.")
                : new GUIContent($"Select Unsafe Type", $"Select from all types, serializable or not. Be aware that some types may not be compatible with all platforms!");
            var buttonStyle = GUI.skin.button;
            var dropdownRect = EditorGUILayout.GetControlRect(false, buttonStyle.CalcHeight(buttonContent, 0f), buttonStyle);
            var toggleRect = new Rect(dropdownRect);
            toggleRect.width = 16f;
            var buttonRect = new Rect(dropdownRect);
            buttonRect.width -= 20f;
            buttonRect.x += 20f;

            EditorGUILayout.BeginHorizontal();
            EditorGUI.BeginChangeCheck();
            safeSearch = EditorGUI.Toggle(toggleRect, safeSearch);
            if(EditorGUI.EndChangeCheck())
            {
                RefreshDropdown();
            }

            if(GUI.Button(buttonRect, buttonContent))
            {
                typeSelectorDropdown.Show(dropdownRect);
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.PropertyField(fullQualifiedName);

            // Draw the different generator options and if a file has been generated, draw it in a disabled objectfield as well.
            EditorGUILayout.Space(EditorGUIUtility.singleLineHeight);
            EditorGUILayout.LabelField($"Options", EditorStyles.boldLabel);
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
                    EditorGUI.BeginDisabledGroup(true);
                    EditorGUILayout.ObjectField(scripts[index], typeof(MonoScript), false);
                    EditorGUI.EndDisabledGroup();
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

        // A NamespaceLevel stores different namespaceLevels of namespaces that have a sub namespace and all the types that have reached this namespaceLevel. NamespaceLevel is used for its recursion to go as many levels deep as it needs to to find all the types of every (sub)namespace it can find.
        private struct NamespaceLevel
        {
            public Dictionary<string, NamespaceLevel> namespaceLevels;
            public IEnumerable<Type> types;

            private Dictionary<int, Type> idTypePairs;

            public NamespaceLevel(IEnumerable<Type> types) : this(0, types) { }
            private NamespaceLevel(int level, IEnumerable<Type> types)
            {
                var typeNamespaceLevelLookup = types.ToLookup(type => type.Namespace != null && type.Namespace.Split('.').Length > level);

                // Populate namespaceLevels.
                var namespaceTypeGroups = from type in typeNamespaceLevelLookup[true]
                                          group type by type.Namespace.Split('.')[level] into namespaceTypeGroup
                                          orderby namespaceTypeGroup.Key
                                          select namespaceTypeGroup;
                this.namespaceLevels = namespaceTypeGroups.ToDictionary(
                    namespaceTypeGroup => namespaceTypeGroup.Key
                    , namespaceTypeGroup => new NamespaceLevel(level + 1, namespaceTypeGroup));

                // Populate types.
                this.types = from type in typeNamespaceLevelLookup[false]
                             orderby type.FullName.Substring(type.FullName.LastIndexOf('.') + 1)
                             select type;

                // Initialize other values.
                this.idTypePairs = new Dictionary<int, Type>();
            }

            public AdvancedDropdownItem GetDropdownItem(AdvancedDropdownItem parent)
            {
                // Draw all the subnamespaces of this namespace level.
                if(namespaceLevels.Count > 0)
                {
                    parent.AddChild(new AdvancedDropdownItem("Namespaces") { enabled = false });
                    foreach(KeyValuePair<string, NamespaceLevel> namespaceLevel in namespaceLevels)
                    {
                        var groupItem = new AdvancedDropdownItem(namespaceLevel.Key);
                        groupItem = namespaceLevel.Value.GetDropdownItem(groupItem);

                        parent.AddChild(groupItem);
                    }
                }

                // Draw all the types of this namespace level.
                idTypePairs.Clear();
                if(types.Any())
                {
                    if(namespaceLevels.Count > 0)
                    {
                        parent.AddSeparator();
                    }

                    parent.AddChild(new AdvancedDropdownItem("Types") { enabled = false });
                    foreach(Type type in types)
                    {
                        var name = type.FullName.Substring(type.FullName.LastIndexOf('.') + 1);
                        if(!type.IsUnitySerializable())
                        {
                            name += " (Not Serializable)";
                        }

                        var dropdownItem = new AdvancedDropdownItem(name);
                        parent.AddChild(dropdownItem);

                        // Use Hash instead of id! If 2 AdvancedDropdownItems have the same name, they will generate the same id (stupid, I know). To ensure searching for a unique identifier, we use the hash instead.
                        idTypePairs.Add(dropdownItem.GetHashCode(), type);
                    }
                }

                return parent;
            }

            // Find the type associated with the AdvancedDropdownItem.
            public Type FindType(AdvancedDropdownItem item)
            {
                if(idTypePairs.TryGetValue(item.GetHashCode(), out var type))
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
            protected new Vector2 minimumSize = new Vector2(0f, 460f);

            private readonly NamespaceLevel typeLevel;
            private readonly Action<Type> typeSelected;

            public TypeSelectorDropdown(IEnumerable<Type> types, Action<Type> typeSelected) : this(new AdvancedDropdownState(), types, typeSelected) { }
            public TypeSelectorDropdown(AdvancedDropdownState state, IEnumerable<Type> types, Action<Type> typeSelected) : base(state)
            {
                this.typeLevel = new NamespaceLevel(types);
                this.typeSelected = typeSelected;

                base.minimumSize = minimumSize;
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
