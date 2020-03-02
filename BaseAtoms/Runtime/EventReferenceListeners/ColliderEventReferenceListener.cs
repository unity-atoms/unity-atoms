using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Collider`. Inherits from `AtomEventReferenceListener&lt;Collider, ColliderAction, ColliderEvent, ColliderEventReference, ColliderUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/Collider Event Reference Listener")]
    public sealed class ColliderEventReferenceListener : AtomEventReferenceListener<
        Collider,
        ColliderAction,
        ColliderEvent,
        ColliderEventReference,
        ColliderUnityEvent>
    { }
}
