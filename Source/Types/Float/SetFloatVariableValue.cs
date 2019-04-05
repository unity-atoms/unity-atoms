using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Float/Set Variable", fileName = "SetFloatVariableValueAction", order = CreateAssetMenuUtils.Order.SET_VARIABLE)]
    public sealed class SetFloatVariableValue : SetVariableValue<
        float,
        FloatVariable,
        FloatReference,
        FloatEvent,
        FloatFloatEvent>
    { }
}
