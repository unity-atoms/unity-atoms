using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.FSM.Editor
{
    /// <summary>
    /// A custom property drawer for References. Makes it possible to choose between a value, Variable, Constant or a Variable Instancer.
    /// </summary>
    [CustomPropertyDrawer(typeof(FiniteStateMachineReference), true)]
    public class FiniteStateMachineReferenceDrawer : AtomBaseReferenceDrawer
    {
        protected class UsageMachine : UsageData
        {
            public override int Value { get => FiniteStateMachineReferenceUsage.MACHINE; }
            public override string PropertyName { get => "_machine"; }
            public override string DisplayName { get => "Use Machine"; }
        }

        protected class UsageMachineInstancer : UsageData
        {
            public override int Value { get => FiniteStateMachineReferenceUsage.MACHINE_INSTANCER; }
            public override string PropertyName { get => "_machineInstancer"; }
            public override string DisplayName { get => "Use Machine Instancer"; }
        }

        private readonly UsageData[] _usages = new UsageData[2] { new UsageMachine(), new UsageMachineInstancer() };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => _usages;
    }
}
