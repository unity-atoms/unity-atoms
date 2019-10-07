using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collider")]
    public sealed class ColliderListener : GameEventListener<
        Collider,
        ColliderAction,
        ColliderEvent,
        UnityColliderEvent>
    { }
}
