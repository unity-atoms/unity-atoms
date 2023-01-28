using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Color`. Inherits from `SetVariableValue&lt;Color, ColorPair, ColorVariable, ColorConstant, ColorReference, ColorEvent, ColorPairEvent, ColorVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Color", fileName = "SetColorVariableValue")]
    public sealed class SetColorVariableValue : SetVariableValue<
        Color,
        ColorPair,
        ColorVariable,
        ColorConstant,
        ColorReference,
        ColorEvent,
        ColorPairEvent,
        ColorColorFunction,
        ColorVariableInstancer>
    { }
}
