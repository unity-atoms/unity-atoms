using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for AtomCollectionReference. Makes it possible to choose between a Collection or a Collection Instancer.
    /// </summary>
    [CustomPropertyDrawer(typeof(AtomCollectionReference), true)]
    public class AtomCollectionReferenceDrawer : AtomBaseReferenceDrawer
    {
        protected class UsageCollection : UsageData
        {
            public override int Value { get => AtomCollectionReferenceUsage.COLLECTION; }
            public override string PropertyName { get => "_collection"; }
            public override string DisplayName { get => "Use Collection"; }
        }

        protected class UsageCollectionInstancer : UsageData
        {
            public override int Value { get => AtomCollectionReferenceUsage.COLLECTION_INSTANCER; }
            public override string PropertyName { get => "_instancer"; }
            public override string DisplayName { get => "Use Collection Instancer"; }
        }

        private readonly UsageData[] _usages = new UsageData[2] { new UsageCollection(), new UsageCollectionInstancer() };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => _usages;
    }
}
