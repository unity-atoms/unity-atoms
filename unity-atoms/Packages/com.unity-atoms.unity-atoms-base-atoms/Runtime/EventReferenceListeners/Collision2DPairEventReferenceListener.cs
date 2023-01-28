using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Collision2DPair`. Inherits from `AtomEventReferenceListener&lt;Collision2DPair, Collision2DPairEvent, Collision2DPairEventReference, Collision2DPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collision2DPair Event Reference Listener")]
    public sealed class Collision2DPairEventReferenceListener : AtomEventReferenceListener<
        Collision2DPair,
        Collision2DPairEvent,
        Collision2DPairEventReference,
        Collision2DPairUnityEvent>
    { }
}
