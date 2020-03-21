using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ColliderPair`. Inherits from `AtomEventReferenceListener&lt;ColliderPair, ColliderPairEvent, ColliderPairEventReference, ColliderPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ColliderPair Event Reference Listener")]
    public sealed class ColliderPairEventReferenceListener : AtomEventReferenceListener<
        ColliderPair,
        ColliderPairEvent,
        ColliderPairEventReference,
        ColliderPairUnityEvent>
    { }
}
