using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Collision")]
    public sealed class CollisionListener : AtomListener<
        Collision,
        CollisionAction,
        CollisionEvent,
        CollisionUnityEvent>
    { }
}
