using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `float`. Inherits from `SetVariableValue&lt;float, FloatPair, FloatVariable, FloatConstant, FloatReference, FloatEvent, FloatPairEvent, FloatVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Float", fileName = "SetFloatVariableValue")]
    public sealed class SetFloatVariableValue : SetVariableValue<
        float,
        FloatPair,
        FloatVariable,
        FloatConstant,
        FloatReference,
        FloatEvent,
        FloatPairEvent,
        FloatFloatFunction,
        FloatVariableInstancer>
    { }
}
