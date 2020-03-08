using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Event Reference Listener of type `TouchUserInput`. Inherits from `AtomEventReferenceListener&lt;TouchUserInput, TouchUserInputEvent, TouchUserInputEventReference, TouchUserInputUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInput Event Reference Listener")]
    public sealed class TouchUserInputEventReferenceListener : AtomEventReferenceListener<
        TouchUserInput,
        TouchUserInputEvent,
        TouchUserInputEventReference,
        TouchUserInputUnityEvent>
    { }
}
