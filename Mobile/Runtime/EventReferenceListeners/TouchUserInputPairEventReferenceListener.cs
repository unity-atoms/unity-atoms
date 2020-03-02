using UnityEngine;
using UnityAtoms.Mobile;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Event Reference Listener of type `TouchUserInputPair`. Inherits from `AtomEventReferenceListener&lt;TouchUserInputPair, TouchUserInputPairAction, TouchUserInputPairEvent, TouchUserInputPairEventReference, TouchUserInputPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/TouchUserInputPair Event Reference Listener")]
    public sealed class TouchUserInputPairEventReferenceListener : AtomEventReferenceListener<
        TouchUserInputPair,
        TouchUserInputPairAction,
        TouchUserInputPairEvent,
        TouchUserInputPairEventReference,
        TouchUserInputPairUnityEvent>
    { }
}
