using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Collider`. Inherits from `AtomListener&lt;Collider, ColliderAction, ColliderEvent, ColliderUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider")]
    public sealed class ColliderListener : AtomListener<
        Collider,
        ColliderAction,
        ColliderEvent,
        ColliderUnityEvent>
    { }
}
