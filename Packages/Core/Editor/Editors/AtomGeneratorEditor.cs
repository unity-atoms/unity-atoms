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
        private TypeSelectorDropdown _typeSelectorDropdown;

        private SerializedProperty _fullQualifiedName;
        private SerializedProperty _generatedOptions;
        private SerializedProperty _customNamespace;

        private static bool _safeSearch = true;

        private void OnEnable()
        {
            _fullQualifiedName = serializedObject.FindProperty(nameof(AtomGenerator.FullQualifiedName));
            _generatedOptions = serializedObject.FindProperty(nameof(AtomGenerator.GenerationOptions));
            _customNamespace = serializedObject.FindProperty(nameof(AtomGenerator.CustomNamespace));

            CheckTypeSafety();
            RefreshDropdown();
        }

        private void CheckTypeSafety()
        {
            var currentType = Type.GetType(_fullQualifiedName.stringValue);
            if (currentType == null || currentType.IsSubclassOf(typeof(Object)))
            {
                _safeSearch = true;
            }
            else if (!currentType.IsSerializable)
            {
                _safeSearch = false;
            }
            else
            {
                var assemblies = from assemblyDefinition in CompilationPipeline.GetAssemblies(AssembliesType.Player)
                                 let assembly = Assembly.Load(assemblyDefinition.name)
                                 select assembly;
                _safeSearch = assemblies.Contains(currentType.Assembly);
            }
        }

        public void RefreshDropdown()
        {
            IEnumerable<Assembly> assemblies;
            if (_safeSearch)
            {
                assemblies = from assemblyDefinition in CompilationPipeline.GetAssemblies(AssembliesType.Player)
                             let assembly = Assembly.Load(assemblyDefinition.name)
                             select assembly;
            }
            else
            {
                assemblies = AppDomain.CurrentDomain.GetAssemblies();
            }

            var types = from assembly in assemblies
                        where !assembly.IsDynamic
                        from type in assembly.GetExportedTypes()
                        where !type.IsGenericType
                        where !type.IsAbstract
                        select type;

            if (_safeSearch)
            {
                types = from type in types
                        where type.IsUnitySerializable()
                        select type;
            }

            _typeSelectorDropdown = new TypeSelectorDropdown(types, selectedType =>
            {
                serializedObject.Update();
                _fullQualifiedName.stringValue = selectedType.AssemblyQualifiedName;
                serializedObject.ApplyModifiedProperties();
            });
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            DrawTypeSelector();

            EditorGUILayout.Space(EditorGUIUtility.singleLineHeight);
            EditorGUILayout.LabelField("Options", EditorStyles.boldLabel);
            
            DrawOptionsToggles();

            serializedObject.ApplyModifiedProperties();

            if (GUILayout.Button("(Re)Generate"))
            {
                (target as AtomGenerator)?.Generate();
                AssetDatabase.SaveAssets();
            }
        }

        private void DrawTypeSelector()
        {
            var buttonContent = _safeSearch
                ? new GUIContent("Select Unity Type", "Select from all Unity compatible types.")
                : new GUIContent("Select Unsafe Type", "Select from all types, serializable or not. Be aware that some types may not be compatible with all platforms!");
            
            var buttonStyle = GUI.skin.button;
            var dropdownRect = EditorGUILayout.GetControlRect(false, buttonStyle.CalcHeight(buttonContent, 0f), buttonStyle);
            var toggleRect = new Rect(dropdownRect) { width = 16f };
            var buttonRect = new Rect(dropdownRect) { width = dropdownRect.width - 20f, x = dropdownRect.x + 20f };

            EditorGUILayout.BeginHorizontal();
            EditorGUI.BeginChangeCheck();
            _safeSearch = EditorGUI.Toggle(toggleRect, _safeSearch);
            if (EditorGUI.EndChangeCheck())
            {
                RefreshDropdown();
            }

            if (GUI.Button(buttonRect, buttonContent))
            {
                _typeSelectorDropdown.Show(dropdownRect);
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.PropertyField(_fullQualifiedName);
            
            EditorGUILayout.Space(2f);
            EditorGUILayout.PropertyField(_customNamespace);
        }

        private void DrawOptionsToggles()
        {
            var options = _generatedOptions.intValue;
            var scripts = (target as AtomGenerator)?.Scripts;

            for (var index = 0; index < AtomTypes.ALL_ATOM_TYPES.Count; index++)
            {
                var atomType = AtomTypes.ALL_ATOM_TYPES[index];
                EditorGUILayout.BeginHorizontal();

                bool isSelected = (options & (1 << index)) == (1 << index);
                EditorGUI.BeginChangeCheck();
                isSelected = EditorGUILayout.Toggle(atomType.DisplayName, isSelected);
                
                if (EditorGUI.EndChangeCheck())
                {
                    if (isSelected)
                    {
                        options |= (1 << index);
                        // Add dependencies
                        if (AtomTypes.DEPENDENCY_GRAPH.TryGetValue(atomType, out var dependencies))
                            dependencies.ForEach(dep => options |= (1 << AtomTypes.ALL_ATOM_TYPES.IndexOf(dep)));
                    }
                    else
                    {
                        options &= ~(1 << index);
                        // Remove dependents
                        foreach (var kvp in AtomTypes.DEPENDENCY_GRAPH.Where(kv => kv.Value.Contains(atomType)))
                        {
                            options &= ~(1 << AtomTypes.ALL_ATOM_TYPES.IndexOf(kvp.Key));
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

            _generatedOptions.intValue = options;
        }

        // Nested helper classes for Dropdown
        private struct NamespaceLevel
        {
            public Dictionary<string, NamespaceLevel> namespaceLevels;
            public IEnumerable<Type> types;
            private Dictionary<int, Type> idTypePairs;

            public NamespaceLevel(IEnumerable<Type> types) : this(0, types) { }
            private NamespaceLevel(int level, IEnumerable<Type> types)
            {
                var typeNamespaceLevelLookup = types.ToLookup(type => type.Namespace != null && type.Namespace.Split('.').Length > level);
                
                this.namespaceLevels = typeNamespaceLevelLookup[true]
                    .GroupBy(type => type.Namespace.Split('.')[level])
                    .OrderBy(g => g.Key)
                    .ToDictionary(g => g.Key, g => new NamespaceLevel(level + 1, g));

                this.types = typeNamespaceLevelLookup[false]
                    .OrderBy(type => type.FullName.Substring(type.FullName.LastIndexOf('.') + 1));

                this.idTypePairs = new Dictionary<int, Type>();
            }

            public AdvancedDropdownItem GetDropdownItem(AdvancedDropdownItem parent)
            {
                if (namespaceLevels.Count > 0)
                {
                    parent.AddChild(new AdvancedDropdownItem("Namespaces") { enabled = false });
                    foreach (var kvp in namespaceLevels)
                    {
                        parent.AddChild(kvp.Value.GetDropdownItem(new AdvancedDropdownItem(kvp.Key)));
                    }
                }

                idTypePairs.Clear();
                if (types.Any())
                {
                    if (namespaceLevels.Count > 0) parent.AddSeparator();
                    parent.AddChild(new AdvancedDropdownItem("Types") { enabled = false });
                    
                    foreach (Type type in types)
                    {
                        var name = type.FullName.Substring(type.FullName.LastIndexOf('.') + 1);
                        if (!type.IsUnitySerializable()) name += " (Not Serializable)";

                        var item = new AdvancedDropdownItem(name);
                        parent.AddChild(item);

                        if (!idTypePairs.ContainsKey(item.GetHashCode()))
                            idTypePairs.Add(item.GetHashCode(), type);
                    }
                }
                return parent;
            }

            public bool TryGetType(AdvancedDropdownItem item, out Type type)
            {
                if (idTypePairs.TryGetValue(item.GetHashCode(), out type)) return true;
                foreach (var level in namespaceLevels.Values)
                    if (level.TryGetType(item, out type)) return true;
                
                type = null;
                return false;
            }
        }

        private class TypeSelectorDropdown : AdvancedDropdown
        {
            private readonly NamespaceLevel _typeLevel;
            private readonly Action<Type> _typeSelected;

            public TypeSelectorDropdown(IEnumerable<Type> types, Action<Type> typeSelected) : base(new AdvancedDropdownState())
            {
                _typeLevel = new NamespaceLevel(types);
                _typeSelected = typeSelected;
                minimumSize = new Vector2(0f, 460f);
            }

            protected override void ItemSelected(AdvancedDropdownItem item)
            {
                base.ItemSelected(item);
                if (item.enabled && _typeLevel.TryGetType(item, out var type))
                    _typeSelected?.Invoke(type);
            }

            protected override AdvancedDropdownItem BuildRoot()
            {
                return _typeLevel.GetDropdownItem(new AdvancedDropdownItem("Serializable Types"));
            }
        }
    }
}