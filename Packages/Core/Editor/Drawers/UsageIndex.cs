using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
	public partial class AtomBaseReferenceDrawer
    {
        private class UsageIndex
        {
            public int Index { get => GetIndex(); set => SetIndex(value); }
            private SerializedProperty property;
            private const string PROPERTY_NAME = "_usage";

            public static UsageIndex GetBy(SerializedProperty property) => new UsageIndex(property);
            
            private UsageIndex(SerializedProperty property) => this.property = property;

            private void SetIndex(int index) => property.FindPropertyRelative(PROPERTY_NAME).intValue = index;
            private int GetIndex() => property.FindPropertyRelative(PROPERTY_NAME).intValue;
        }
    }
}