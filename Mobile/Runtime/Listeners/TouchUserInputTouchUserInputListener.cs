using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Listener x 2 of type `TouchUserInput`. Inherits from `AtomX2Listener&lt;TouchUserInput, TouchUserInputTouchUserInputAction, TouchUserInputVariable, TouchUserInputEvent, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputFunction, TouchUserInputVariableInstancer, TouchUserInputTouchUserInputEventReference, TouchUserInputTouchUserInputUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput x 2 Listener")]
    public sealed class TouchUserInputTouchUserInputListener : AtomX2Listener<
        TouchUserInput,
        TouchUserInputTouchUserInputAction,
        TouchUserInputVariable,
        TouchUserInputEvent,
        TouchUserInputTouchUserInputEvent,
        TouchUserInputTouchUserInputFunction,
        TouchUserInputVariableInstancer,
        TouchUserInputTouchUserInputEventReference,
        TouchUserInputTouchUserInputUnityEvent>
    { }
}
