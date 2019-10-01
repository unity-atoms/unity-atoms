using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Float", fileName = "SetFloatVariableValue")]
    public sealed class SetFloatVariableValue : SetVariableValue<
        float,
        FloatVariable,
        FloatReference,
        FloatEvent,
        FloatFloatEvent>
    { }
}
