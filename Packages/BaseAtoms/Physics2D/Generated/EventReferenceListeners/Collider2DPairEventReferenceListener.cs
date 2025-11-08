using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Collider2DPair`. Inherits from `AtomEventReferenceListener&lt;Collider2DPair, Collider2DPairEvent, Collider2DPairEventReference, Collider2DPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2DPair Event Reference Listener")]
    public sealed class Collider2DPairEventReferenceListener : AtomEventReferenceListener<
        Collider2DPair,
        Collider2DPairEvent,
        Collider2DPairEventReference,
        Collider2DPairUnityEvent>
    { }
}
