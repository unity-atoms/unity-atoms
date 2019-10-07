using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D")]
    public sealed class ColliderListener : GameEventListener<
        Collider,
        ColliderAction,
        ColliderEvent,
        UnityColliderEvent>
    { }
}
