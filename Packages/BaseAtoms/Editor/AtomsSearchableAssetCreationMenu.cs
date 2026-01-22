using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public static class AtomsSearchableAssetCreationMenu
    {
        class StringTree<T>
        {
            public Dictionary<string, StringTree<T>> SubTrees { get; } = new Dictionary<string, StringTree<T>>();
            public T Value { get; private set; }

            public void Insert(string path, T value, int idx = 0)
            {
                Internal_Insert(path.Split('/'), idx, value);
            }

            private void Internal_Insert(string[] path, int idx, T value)
            {
                if (idx >= path.Length)
                {
                    Value = value;
                    return;
                }

                if (!SubTrees.ContainsKey(path[idx])) SubTrees.Add(path[idx], new StringTree<T>());
                SubTrees[path[idx]].Internal_Insert(path, idx + 1, value);
            }
        }

        // Custom item to hold the Type data directly, avoiding ID/Index dependency issues in Unity 6
        private class AtomsDropdownItem : AdvancedDropdownItem
        {
            public Type AtomType { get; }

            public AtomsDropdownItem(string name, Type type) : base(name)
            {
                AtomType = type;
            }
        }

        [MenuItem(itemName: "Assets/Create/Atoms Search &1", isValidateFunction: false, priority: -1)]
        public static void AtomsSearchMenu()
        {
            StringTree<Type> typeTree = new StringTree<Type>();

            foreach (var type in TypeCache.GetTypesWithAttribute<CreateAssetMenuAttribute>()
                .Where(t => t.GetCustomAttribute<AtomsSearchable>(true) != null))
            {
                var name = type.GetCustomAttribute<CreateAssetMenuAttribute>().menuName;
                var i = name.LastIndexOf('/');
                name = (i == -1) ? name : name.Substring(0, i + 1) + type.Name;
                typeTree.Insert(name, type, 1);
            }

            var projectBrowserType = typeof(UnityEditor.Editor).Assembly.GetType("UnityEditor.ProjectBrowser");
            var projectBrowser = EditorWindow.GetWindow(projectBrowserType);

            Rect rect;
            if (projectBrowser != null)
            {
                Vector2 xy = new Vector2(projectBrowser.position.x + 10, projectBrowser.position.y + 60);
                rect = new Rect(xy.x, xy.y, projectBrowser.position.width - 20, projectBrowser.position.height);
            }
            else
            {
                rect = new Rect(100, 100, 300, 400);
            }

            var dropdown = new SearchTypeDropdown(new AdvancedDropdownState(), typeTree,
                (s) =>
                {
                    EditorApplication.ExecuteMenuItem("Assets/Create/" + s.GetCustomAttribute<CreateAssetMenuAttribute>().menuName);
                })
            {
                MinimumSize = new Vector2(rect.width, rect.height - 80)
            };

            dropdown.Show(new Rect());

            var windowField = typeof(AdvancedDropdown).GetField("m_WindowInstance", BindingFlags.Instance | BindingFlags.NonPublic);
            var window = windowField?.GetValue(dropdown) as EditorWindow;
            if (window != null)
            {
                window.position = rect;
            }
        }

        private class SearchTypeDropdown : AdvancedDropdown
        {
            private readonly StringTree<Type> _list;
            private readonly Action<Type> _func;
            
            public Vector2 MinimumSize
            {
                get => minimumSize;
                set => minimumSize = value;
            }

            public SearchTypeDropdown(AdvancedDropdownState state, StringTree<Type> list, Action<Type> func) : base(state)
            {
                _list = list;
                _func = func;
            }

            protected override void ItemSelected(AdvancedDropdownItem item)
            {
                base.ItemSelected(item);
                
                // Unity 6 safe check: verify if the item is our custom type and has data
                if (item is AtomsDropdownItem atomsItem && atomsItem.AtomType != null)
                {
                    _func?.Invoke(atomsItem.AtomType);
                }
            }

            private void Render(StringTree<Type> tree, string key, AdvancedDropdownItem parentGroup)
            {
                if (tree.Value != null)
                {
                    // Create custom item with the Type directly
                    parentGroup.AddChild(new AtomsDropdownItem(key, tree.Value));
                }
                else
                {
                    var self = new AdvancedDropdownItem(key);
                    foreach (var subtree in tree.SubTrees)
                    {
                        Render(subtree.Value, subtree.Key, self);
                    }
                    parentGroup.AddChild(self);
                }
            }

            protected override AdvancedDropdownItem BuildRoot()
            {
                var root = new AdvancedDropdownItem("Unity Atoms");
                foreach (var subtree in _list.SubTrees)
                {
                    Render(subtree.Value, subtree.Key, root);
                }
                return root;
            }
        }
    }
}
