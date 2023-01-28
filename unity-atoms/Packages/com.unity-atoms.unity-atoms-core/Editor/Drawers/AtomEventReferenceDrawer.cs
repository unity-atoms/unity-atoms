using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for Event References. Makes it possible to choose between an Event, Event Instancer, Variable or a Variable Instancer.
    /// </summary>
    [CustomPropertyDrawer(typeof(AtomBaseEventReference), true)]
    public class AtomEventReferenceDrawer : AtomBaseReferenceDrawer
    {
        protected class UsageEvent : UsageData
        {
            public override int Value { get => AtomEventReferenceUsage.EVENT; }
            public override string PropertyName { get => "_event"; }
            public override string DisplayName { get => "Use Event"; }
        }

        protected class UsageEventInstancer : UsageData
        {
            public override int Value { get => AtomEventReferenceUsage.EVENT_INSTANCER; }
            public override string PropertyName { get => "_eventInstancer"; }
            public override string DisplayName { get => "Use Event Instancer"; }
        }

        protected class UsageVariable : UsageData
        {
            public override int Value { get => AtomReferenceUsage.VARIABLE; }
            public override string PropertyName { get => "_variable"; }
            public override string DisplayName { get => "Use Variable"; }
        }

        protected class UsageVariableInstancer : UsageData
        {
            public override int Value { get => AtomReferenceUsage.VARIABLE_INSTANCER; }
            public override string PropertyName { get => "_variableInstancer"; }
            public override string DisplayName { get => "Use Variable Instancer"; }
        }

        private readonly UsageData[] _usagesOnlyEvents = new UsageData[2] { new UsageEvent(), new UsageEventInstancer() };
        private readonly UsageData[] _usages = new UsageData[4] { new UsageEvent(), new UsageEventInstancer(), new UsageVariable(), new UsageVariableInstancer() };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => prop.FindPropertyRelative("_variable") != null ? _usages : _usagesOnlyEvents;
    }
}
