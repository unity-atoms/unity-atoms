using UnityEngine;

namespace UnityAtoms
{
    public sealed class ColliderGameObjectListener : GameEventListener<
        Collider,
        GameObject,
        ColliderGameObjectAction,
        ColliderGameObjectEvent,
        UnityColliderGameObjectEvent>
    { }
}
