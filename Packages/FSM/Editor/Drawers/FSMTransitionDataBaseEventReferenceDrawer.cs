using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.FSM.Editor
{
    /// <summary>
    /// A custom property drawer for References. Makes it possible to choose between a value, Variable, Constant or a Variable Instancer.
    /// </summary>
    [CustomPropertyDrawer(typeof(FSMTransitionDataBaseEventReference), true)]
    public class FSMTransitionDataBaseEventReferenceDrawer : AtomEventReferenceDrawer
    {
        protected class UsageFSM : UsageData
        {
            public override int Value { get => FSMTransitionDataBaseEventReferenceUsage.FSM; }
            public override string PropertyName { get => "_fsm"; }
            public override string DisplayName { get => "Use FSM"; }
        }

        protected class UsageFSMInstancer : UsageData
        {
            public override int Value { get => FSMTransitionDataBaseEventReferenceUsage.FSM_INSTANCER; }
            public override string PropertyName { get => "_fsmInstancer"; }
            public override string DisplayName { get => "Use FSM Instancer"; }
        }

        private readonly UsageData[] _usages = new UsageData[4] { new UsageEvent(), new UsageEventInstancer(), new UsageFSM(), new UsageFSMInstancer() };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => _usages;
    }
}
