using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Collider`. Inherits from `AtomEventReferenceListener&lt;Collider, ColliderEvent, ColliderEventReference, ColliderUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider Event Reference Listener")]
    public sealed class ColliderEventReferenceListener : AtomEventReferenceListener<
        Collider,
        ColliderEvent,
        ColliderEventReference,
        ColliderUnityEvent>
    { }
}
