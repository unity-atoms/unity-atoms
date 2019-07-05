using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable/Float", fileName = "SetFloatVariableValueAction")]
    public sealed class SetFloatVariableValue : SetVariableValue<
        float,
        FloatVariable,
        FloatReference,
        FloatEvent,
        FloatFloatEvent>
    { }
}
