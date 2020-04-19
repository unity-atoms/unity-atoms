using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Variable Instancer of type `TouchUserInput`. Inherits from `AtomVariableInstancer&lt;TouchUserInputVariable, TouchUserInputPair, TouchUserInput, TouchUserInputEvent, TouchUserInputPairEvent, TouchUserInputTouchUserInputFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/TouchUserInput Variable Instancer")]
    public class TouchUserInputVariableInstancer : AtomVariableInstancer<
        TouchUserInputVariable,
        TouchUserInputPair,
        TouchUserInput,
        TouchUserInputEvent,
        TouchUserInputPairEvent,
        TouchUserInputTouchUserInputFunction>
    { }
}
