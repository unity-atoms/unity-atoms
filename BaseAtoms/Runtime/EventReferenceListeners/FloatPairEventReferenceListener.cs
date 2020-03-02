using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `FloatPair`. Inherits from `AtomEventReferenceListener&lt;FloatPair, FloatPairAction, FloatPairEvent, FloatPairEventReference, FloatPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/FloatPair Event Reference Listener")]
    public sealed class FloatPairEventReferenceListener : AtomEventReferenceListener<
        FloatPair,
        FloatPairAction,
        FloatPairEvent,
        FloatPairEventReference,
        FloatPairUnityEvent>
    { }
}
