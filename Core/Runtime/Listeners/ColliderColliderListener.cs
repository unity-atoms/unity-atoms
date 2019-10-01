using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collider - Collider")]
    public sealed class ColliderColliderListener : AtomListener<
        Collider,
        Collider,
        ColliderColliderAction,
        ColliderColliderEvent,
        ColliderColliderUnityEvent>
    { }
}
