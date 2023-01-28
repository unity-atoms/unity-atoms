using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for Void BaseEventReferences. Makes it possible to choose between an Event, Event Instancer, Collection Cleared, List Cleared, Collection Instancer Cleared or List Instancer Cleared.
    /// </summary>
    [CustomPropertyDrawer(typeof(VoidBaseEventReference), true)]
    public class VoidBaseEventReferenceDrawer : AtomBaseReferenceDrawer
    {
        protected class UsageEvent : UsageData
        {
            public override int Value { get => VoidBaseEventReferenceUsage.EVENT; }
            public override string PropertyName { get => "_event"; }
            public override string DisplayName { get => "Use Event"; }
        }

        protected class UsageEventInstancer : UsageData
        {
            public override int Value { get => VoidBaseEventReferenceUsage.EVENT_INSTANCER; }
            public override string PropertyName { get => "_eventInstancer"; }
            public override string DisplayName { get => "Use Event Instancer"; }
        }

        protected class UsageCollectionCleared : UsageData
        {
            public override int Value { get => VoidBaseEventReferenceUsage.COLLECTION_CLEARED_EVENT; }
            public override string PropertyName { get => "_collection"; }
            public override string DisplayName { get => "Use Collection Cleared Event"; }
        }

        protected class UsageListCleared : UsageData
        {
            public override int Value { get => VoidBaseEventReferenceUsage.LIST_CLEARED_EVENT; }
            public override string PropertyName { get => "_list"; }
            public override string DisplayName { get => "Use List Cleared Event"; }
        }

        protected class UsageCollectionInstancerCleared : UsageData
        {
            public override int Value { get => VoidBaseEventReferenceUsage.COLLECTION_INSTANCER_CLEARED_EVENT; }
            public override string PropertyName { get => "_collectionInstancer"; }
            public override string DisplayName { get => "Use Collection Instancer Cleared Event"; }
        }

        protected class UsageListInstancerCleared : UsageData
        {
            public override int Value { get => VoidBaseEventReferenceUsage.LIST_INSTANCER_CLEARED_EVENT; }
            public override string PropertyName { get => "_listInstancer"; }
            public override string DisplayName { get => "Use List Instancer Cleared Event"; }
        }

        private readonly UsageData[] _usages = new UsageData[6] {
            new UsageEvent(),
            new UsageEventInstancer(),
            new UsageCollectionCleared(),
            new UsageListCleared(),
            new UsageCollectionInstancerCleared(),
            new UsageListInstancerCleared()
        };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => _usages;
    }
}
