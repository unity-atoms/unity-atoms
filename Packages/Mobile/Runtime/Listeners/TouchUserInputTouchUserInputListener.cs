using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Listener x 2 of type `TouchUserInput`. Inherits from `AtomListener&lt;TouchUserInput, TouchUserInput, TouchUserInputTouchUserInputAction, TouchUserInputTouchUserInputEvent, TouchUserInputTouchUserInputUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput x 2 Listener")]
    public sealed class TouchUserInputTouchUserInputListener : AtomListener<
        TouchUserInput,
        TouchUserInput,
        TouchUserInputTouchUserInputAction,
        TouchUserInputTouchUserInputEvent,
        TouchUserInputTouchUserInputUnityEvent>
    { }
}
