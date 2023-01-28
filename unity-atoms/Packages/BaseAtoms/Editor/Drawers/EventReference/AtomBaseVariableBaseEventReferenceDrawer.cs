using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for AtomBaseVariable BaseEventReferences. Makes it possible to choose between an Event, Event Instancer, Collection Added, Collection Removed, List Added, List Removed, Collection Instancer Added, Collection Instancer Removed, List Instancer Added or List Instancer Removed.
    /// </summary>
    [CustomPropertyDrawer(typeof(AtomBaseVariableBaseEventReference), true)]
    public class AtomBaseVariableBaseEventReferenceDrawer : AtomBaseReferenceDrawer
    {
        protected class UsageEvent : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.EVENT; }
            public override string PropertyName { get => "_event"; }
            public override string DisplayName { get => "Use Event"; }
        }

        protected class UsageEventInstancer : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.EVENT_INSTANCER; }
            public override string PropertyName { get => "_eventInstancer"; }
            public override string DisplayName { get => "Use Event Instancer"; }
        }

        protected class UsageCollectionAdded : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.COLLECTION_ADDED_EVENT; }
            public override string PropertyName { get => "_collection"; }
            public override string DisplayName { get => "Use Collection Added Event"; }
        }

        protected class UsageCollectionRemoved : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.COLLECTION_REMOVED_EVENT; }
            public override string PropertyName { get => "_collection"; }
            public override string DisplayName { get => "Use Collection Removed Event"; }
        }

        protected class UsageListAdded : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.LIST_ADDED_EVENT; }
            public override string PropertyName { get => "_list"; }
            public override string DisplayName { get => "Use List Added Event"; }
        }

        protected class UsageListRemoved : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.LIST_REMOVED_EVENT; }
            public override string PropertyName { get => "_list"; }
            public override string DisplayName { get => "Use List Removed Event"; }
        }

        protected class UsageCollectionInstancerAdded : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.COLLECTION_INSTANCER_ADDED_EVENT; }
            public override string PropertyName { get => "_collectionInstancer"; }
            public override string DisplayName { get => "Use Collection Instancer Added Event"; }
        }

        protected class UsageCollectionInstancerRemoved : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.COLLECTION_INSTANCER_REMOVED_EVENT; }
            public override string PropertyName { get => "_collectionInstancer"; }
            public override string DisplayName { get => "Use Collection Instancer Removed Event"; }
        }

        protected class UsageListInstancerAdded : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.LIST_INSTANCER_ADDED_EVENT; }
            public override string PropertyName { get => "_listInstancer"; }
            public override string DisplayName { get => "Use List Instancer Added Event"; }
        }

        protected class UsageListInstancerRemoved : UsageData
        {
            public override int Value { get => AtomBaseVariableEventReferenceUsage.LIST_INSTANCER_REMOVED_EVENT; }
            public override string PropertyName { get => "_listInstancer"; }
            public override string DisplayName { get => "Use List Instancer Removed Event"; }
        }

        private readonly UsageData[] _usages = new UsageData[10] {
            new UsageEvent(),
            new UsageEventInstancer(),
            new UsageCollectionAdded(),
            new UsageCollectionRemoved(),
            new UsageListAdded(),
            new UsageListRemoved(),
            new UsageCollectionInstancerAdded(),
            new UsageCollectionInstancerRemoved(),
            new UsageListInstancerAdded(),
            new UsageListInstancerRemoved()
        };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => _usages;
    }
}
