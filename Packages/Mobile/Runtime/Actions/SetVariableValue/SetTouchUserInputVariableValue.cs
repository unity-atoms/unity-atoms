using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Set variable value Action of type `TouchUserInput`. Inherits from `SetVariableValue&lt;TouchUserInput, TouchUserInputVariable, TouchUserInputReference, TouchUserInputEvent, TouchUserInputTouchUserInputEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/TouchUserInput", fileName = "SetTouchUserInputVariableValue")]
    public sealed class SetTouchUserInputVariableValue : SetVariableValue<
        TouchUserInput,
        TouchUserInputVariable,
        TouchUserInputReference,
        TouchUserInputEvent,
        TouchUserInputTouchUserInputEvent>
    { }
}
