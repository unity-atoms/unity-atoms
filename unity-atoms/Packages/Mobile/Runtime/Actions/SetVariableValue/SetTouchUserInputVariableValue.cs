using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Set variable value Action of type `TouchUserInput`. Inherits from `SetVariableValue&lt;TouchUserInput, TouchUserInputPair, TouchUserInputVariable, TouchUserInputConstant, TouchUserInputReference, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/TouchUserInput", fileName = "SetTouchUserInputVariableValue")]
    public sealed class SetTouchUserInputVariableValue : SetVariableValue<
        TouchUserInput,
        TouchUserInputPair,
        TouchUserInputVariable,
        TouchUserInputConstant,
        TouchUserInputReference,
        TouchUserInputEvent,
        TouchUserInputPairEvent,
        TouchUserInputTouchUserInputFunction,
        TouchUserInputVariableInstancer>
    { }
}
