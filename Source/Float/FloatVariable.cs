using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Float/Variable", fileName = "FloatVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public class FloatVariable : EquatableScriptableObjectVariable<float, FloatEvent, FloatFloatEvent>, IWithApplyChange<float, FloatEvent, FloatFloatEvent>
    {
        public bool ApplyChange(float amount)
        {
            return SetValue(Value + amount);
        }

        public bool ApplyChange(EquatableScriptableObjectVariable<float, FloatEvent, FloatFloatEvent> amount)
        {
            return SetValue(Value + amount.Value);
        }
    }
}