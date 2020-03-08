using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for References. Makes it possible to choose between a Value, Variable, Constant or a Variable Instancer.
    /// </summary>

    [CustomPropertyDrawer(typeof(AtomBaseReference), true)]
    public class AtomReferenceDrawer : AtomBaseReferenceDrawer
    {
        protected class UsageValue : UsageData
        {
            public override int Value { get => AtomReferenceUsage.VALUE; }
            public override string PropertyName { get => "_value"; }
            public override string DisplayName { get => "Use Value"; }
        }

        protected class UsageConstant : UsageData
        {
            public override int Value { get => AtomReferenceUsage.CONSTANT; }
            public override string PropertyName { get => "_constant"; }
            public override string DisplayName { get => "Use Constant"; }
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

        private readonly UsageData[] _usages = new UsageData[4] { new UsageValue(), new UsageConstant(), new UsageVariable(), new UsageVariableInstancer() };

        protected override UsageData[] GetUsages(SerializedProperty prop = null) => _usages;
    }
}
