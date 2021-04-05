using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `CollisionGameObjectPair`. Inherits from `AtomEventReferenceListener&lt;CollisionGameObjectPair, CollisionGameObjectPairEvent, CollisionGameObjectPairEventReference, CollisionGameObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CollisionGameObjectPair Event Reference Listener")]
    public sealed class CollisionGameObjectPairEventReferenceListener : AtomListener<Pair<CollisionGameObject>>
    { }
}
