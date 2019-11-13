using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Listener of type `TouchUserInput`. Inherits from `AtomListener&lt;TouchUserInput, TouchUserInputAction, TouchUserInputEvent, TouchUserInputUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput Listener")]
    public sealed class TouchUserInputListener : AtomListener<
        TouchUserInput,
        TouchUserInputAction,
        TouchUserInputEvent,
        TouchUserInputUnityEvent>
    { }
}
