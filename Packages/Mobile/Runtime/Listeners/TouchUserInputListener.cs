using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Listener of type `TouchUserInput`. Inherits from `AtomListener&lt;TouchUserInput, TouchUserInputAction, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer, TouchUserInputEventReference, TouchUserInputUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput Listener")]
    public sealed class TouchUserInputListener : AtomListener<
        TouchUserInput,
        TouchUserInputAction,
        TouchUserInputVariable,
        TouchUserInputEvent,
        TouchUserInputTouchUserInputEvent,
        TouchUserInputTouchUserInputFunction,
        TouchUserInputVariableInstancer,
        TouchUserInputEventReference,
        TouchUserInputUnityEvent>
    { }
}
