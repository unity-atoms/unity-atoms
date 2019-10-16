using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `float`. Inherits from `SetVariableValue&lt;float, FloatVariable, FloatConstant, FloatReference, FloatEvent, FloatFloatEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Float", fileName = "SetFloatVariableValue")]
    public sealed class SetFloatVariableValue : SetVariableValue<
        float,
        FloatVariable,
        FloatConstant,
        FloatReference,
        FloatEvent,
        FloatFloatEvent>
    { }
}
