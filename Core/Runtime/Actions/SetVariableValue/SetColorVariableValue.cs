using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Color`. Inherits from `SetVariableValue&lt;Color, ColorVariable, ColorReference, ColorEvent, ColorColorEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Color", fileName = "SetColorVariableValue")]
    public sealed class SetColorVariableValue : SetVariableValue<
        Color,
        ColorVariable,
        ColorReference,
        ColorEvent,
        ColorColorEvent>
    { }
}
