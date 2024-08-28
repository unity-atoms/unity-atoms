using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityEngine.Collider`. Inherits from `AtomEventReferenceListener&lt;UnityEngine.Collider, ColliderEvent, ColliderEventReference, ColliderUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider Event Reference Listener")]
    public sealed class ColliderEventReferenceListener : AtomEventReferenceListener<
        UnityEngine.Collider,
        ColliderEvent,
        ColliderEventReference,
        ColliderUnityEvent>
    { }
}
