using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collision")]
    public sealed class CollisionListener : GameEventListener<
        Collision,
        CollisionAction,
        CollisionEvent,
        UnityCollisionEvent>
    { }
}
