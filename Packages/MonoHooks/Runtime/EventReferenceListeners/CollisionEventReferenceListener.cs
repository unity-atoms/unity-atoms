using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Collision`. Inherits from `AtomEventReferenceListener&lt;Collision, CollisionEvent, CollisionEventReference, CollisionUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collision Event Reference Listener")]
    public sealed class CollisionEventReferenceListener : AtomEventReferenceListener<
        Collision,
        CollisionEvent,
        CollisionEventReference,
        CollisionUnityEvent>
    { }
}
