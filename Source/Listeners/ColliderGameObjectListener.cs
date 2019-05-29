using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collider - GameObject")]
    public sealed class ColliderGameObjectListener : GameEventListener<
        Collider,
        GameObject,
        ColliderGameObjectAction,
        ColliderGameObjectEvent,
        UnityColliderGameObjectEvent>
    { }
}
