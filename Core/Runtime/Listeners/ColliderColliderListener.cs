using UnityEngine;

namespace UnityAtoms
{
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
