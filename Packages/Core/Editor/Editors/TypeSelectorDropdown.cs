using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace UnityAtoms.Editor
{
    public class TypeSelectorDropdown : AdvancedDropdown
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
            if (item.enabled && typeLevel.TryGetType(item, out var type))
            {
                typeSelected?.Invoke(type);
            }
        }

        protected override AdvancedDropdownItem BuildRoot()
        {
            return typeLevel.GetDropdownItem(new AdvancedDropdownItem("Serializable Types"));
        }

        // A NamespaceLevel stores different namespaceLevels of namespaces that have a sub namespace and all the types that have reached this namespaceLevel. NamespaceLevel is used for its recursion to go as many levels deep as it needs to to find all the types of every (sub)namespace it can find.
        public struct NamespaceLevel
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
                if (namespaceLevels.Count > 0)
                {
                    parent.AddChild(new AdvancedDropdownItem("Namespaces") { enabled = false });
                    foreach (KeyValuePair<string, NamespaceLevel> namespaceLevel in namespaceLevels)
                    {
                        var groupItem = new AdvancedDropdownItem(namespaceLevel.Key);
                        groupItem = namespaceLevel.Value.GetDropdownItem(groupItem);

                        parent.AddChild(groupItem);
                    }
                }

                // Draw all the types of this namespace level.
                idTypePairs.Clear();
                if (types.Any())
                {
                    if (namespaceLevels.Count > 0)
                    {
                        parent.AddSeparator();
                    }

                    parent.AddChild(new AdvancedDropdownItem("Types") { enabled = false });
                    foreach (Type type in types)
                    {
                        var name = type.FullName.Substring(type.FullName.LastIndexOf('.') + 1);
                        if (!type.IsUnitySerializable())
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
                if (idTypePairs.TryGetValue(item.GetHashCode(), out var type))
                {
                    return type;
                }

                foreach (NamespaceLevel namespaceLevel in namespaceLevels.Values)
                {
                    if (namespaceLevel.TryGetType(item, out type))
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
    }
}
