using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for AtomListReference. Makes it possible to choose between a List or a List Instancer.
    /// </summary>
    [CustomPropertyDrawer(typeof(AtomListReference), true)]
    public class AtomListReferenceDrawer : AtomBaseReferenceDrawer
    {
        protected class UsageList : UsageData
        {
            public override int Value { get => AtomListReferenceUsage.LIST; }
            public override string PropertyName { get => "_list"; }
            public override string DisplayName { get => "Use List"; }
        }

        protected class UsageListInstancer : UsageData
        {
            public override int Value { get => AtomListReferenceUsage.LIST_INSTANCER; }
            public override string PropertyName { get => "_instancer"; }
            public override string DisplayName { get => "Use List Instancer"; }
        }

        private readonly UsageData[] _usages = new UsageData[2] { new UsageList(), new UsageListInstancer() };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => _usages;
    }
}
