using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `FloatPair`. Inherits from `AtomEventReferenceListener&lt;FloatPair, FloatPairEvent, FloatPairEventReference, FloatPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/FloatPair Event Reference Listener")]
    public sealed class FloatPairEventReferenceListener : AtomEventReferenceListener<
        FloatPair,
        FloatPairEvent,
        FloatPairEventReference,
        FloatPairUnityEvent>
    { }
}
