using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using UnityAtoms;

namespace UnityAtoms.Editor
{
    [CustomEditor(typeof(AtomGenerator))]
    public class AtomGeneratorEditor : UnityEditor.Editor
    {
        private IEnumerable<IGrouping<string, Type>> _types;
        private SearchTypeDropdown _typeSelectorPopup;

        private void OnEnable()
        {
            _types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetExportedTypes())
                .Where(x => x != null)
                .Where(x => x.IsValueType || (x.Attributes & TypeAttributes.Serializable) != 0)
                .Where(t => !(t.Namespace?.Contains("Microsoft") ?? false))
                .Where(t => !(t.Namespace?.Contains("UnityEditor") ?? false))
                .GroupBy(t => t.Namespace.Split('.')[0]);
        }

        public override void OnInspectorGUI()
        {
            var rect = GUILayoutUtility.GetRect(new GUIContent("Show"), EditorStyles.toolbarButton);

            if (GUILayout.Button("Select Type"))
            {
                var dropdown = new SearchTypeDropdown(new AdvancedDropdownState(), _types, (s) =>
                {
                    serializedObject.FindProperty("Namespace").stringValue = s.Split(':')[0];
                    serializedObject.FindProperty("BaseType").stringValue = s.Split(':')[1];
                    var type = _types.First(grouping =>
                            grouping.Key == serializedObject.FindProperty("Namespace").stringValue)
                        .First(t => t.Name == serializedObject.FindProperty("BaseType").stringValue);
                    serializedObject.FindProperty("FullQualifiedName").stringValue = type.AssemblyQualifiedName;
                });
                dropdown.Show(rect);
            }

            EditorGUILayout.PropertyField(serializedObject.FindProperty("FullQualifiedName"));

            var options = serializedObject.FindProperty("GenerationOptions").intValue;

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

            serializedObject.FindProperty("GenerationOptions").intValue = options;

            serializedObject.ApplyModifiedProperties();
            if (GUILayout.Button("(Re)Generate"))
            {
                (target as AtomGenerator)?.Generate();
                AssetDatabase.SaveAssets();
            }
        }

        private class SearchTypeDropdown : AdvancedDropdown
        {
            private readonly IEnumerable<IGrouping<string, Type>> _list;
            private readonly Action<string> _func;

            public SearchTypeDropdown(AdvancedDropdownState state, IEnumerable<IGrouping<string, Type>> list,
                Action<string> func) : base(state)
            {
                _list = list;
                _func = func;
            }

            protected override void ItemSelected(AdvancedDropdownItem item)
            {
                base.ItemSelected(item);
                _func?.Invoke(item.name);
            }

            protected override AdvancedDropdownItem BuildRoot()
            {
                var root = new AdvancedDropdownItem("Serializable Types");


                foreach (var group in _list)
                {
                    var groupItem = new AdvancedDropdownItem(group.Key);
                    foreach (var type in group)
                    {
                        groupItem.AddChild(new AdvancedDropdownItem(group.Key + ":" + type.Name));
                    }

                    root.AddChild(groupItem);
                }

                return root;
            }
        }
    }
}
