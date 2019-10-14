using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Float", fileName = "SetFloatVariableValue")]
    public sealed class SetFloatVariableValue : SetVariableValue<
        float,
        FloatVariable,
        FloatReference,
        FloatEvent,
        FloatFloatEvent>
    { }
}
