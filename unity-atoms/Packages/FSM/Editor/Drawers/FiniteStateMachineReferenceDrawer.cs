using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.FSM.Editor
{
    /// <summary>
    /// A custom property drawer for FiniteStateMachineReference. Makes it possible to choose between a FSM or a FSM Instancer.
    /// </summary>
    [CustomPropertyDrawer(typeof(FiniteStateMachineReference), true)]
    public class FiniteStateMachineReferenceDrawer : AtomBaseReferenceDrawer
    {
        protected class UsageFSM : UsageData
        {
            public override int Value { get => FiniteStateMachineReferenceUsage.FSM; }
            public override string PropertyName { get => "_fsm"; }
            public override string DisplayName { get => "Use FSM"; }
        }

        protected class UsageFSMInstancer : UsageData
        {
            public override int Value { get => FiniteStateMachineReferenceUsage.FSM_INSTANCER; }
            public override string PropertyName { get => "_fsmInstancer"; }
            public override string DisplayName { get => "Use FSM Instancer"; }
        }

        private readonly UsageData[] _usages = new UsageData[2] { new UsageFSM(), new UsageFSMInstancer() };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => _usages;
    }
}
