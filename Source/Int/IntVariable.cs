using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Int/Variable", fileName = "IntVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public class IntVariable : EquatableScriptableObjectVariable<int, IntEvent, IntIntEvent>, IWithApplyChange<int, IntEvent, IntIntEvent>
    {
        public bool ApplyChange(int amount)
        {
            return SetValue(Value + amount);
        }

        public bool ApplyChange(EquatableScriptableObjectVariable<int, IntEvent, IntIntEvent> amount)
        {
            return SetValue(Value + amount.Value);
        }
    }
}