using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `CollisionPair`. Inherits from `AtomEventReferenceListener&lt;CollisionPair, CollisionPairEvent, CollisionPairEventReference, CollisionPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CollisionPair Event Reference Listener")]
    public sealed class CollisionPairEventReferenceListener : AtomListener<Pair<Collision>>
    { }
}
