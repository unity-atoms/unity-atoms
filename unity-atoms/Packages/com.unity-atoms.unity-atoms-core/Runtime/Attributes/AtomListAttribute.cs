using UnityEngine;

namespace UnityAtoms
{
    public class AtomListAttribute : PropertyAttribute
    {
        public string Label { get; set; }
        public string ChildPropName { get; set; }
        public bool IncludeChildrenForItems { get; set; }

        public AtomListAttribute(string label = null, string childPropName = "_list", bool includeChildrenForItems = true)
        {
            Label = label;
            ChildPropName = childPropName;
            IncludeChildrenForItems = includeChildrenForItems;
        }
    }
}