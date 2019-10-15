using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Collider`. Inherits from `AtomListener&lt;Collider, Collider, ColliderColliderAction, ColliderColliderEvent, ColliderColliderUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider - Collider")]
    public sealed class ColliderColliderListener : AtomListener<
        Collider,
        Collider,
        ColliderColliderAction,
        ColliderColliderEvent,
        ColliderColliderUnityEvent>
    { }
}
