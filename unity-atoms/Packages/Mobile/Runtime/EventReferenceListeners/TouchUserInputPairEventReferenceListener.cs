using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Event Reference Listener of type `TouchUserInputPair`. Inherits from `AtomEventReferenceListener&lt;TouchUserInputPair, TouchUserInputPairEvent, TouchUserInputPairEventReference, TouchUserInputPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TouchUserInputPair Event Reference Listener")]
    public sealed class TouchUserInputPairEventReferenceListener : AtomEventReferenceListener<
        TouchUserInputPair,
        TouchUserInputPairEvent,
        TouchUserInputPairEventReference,
        TouchUserInputPairUnityEvent>
    { }
}
