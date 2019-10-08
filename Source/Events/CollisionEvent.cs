using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collision", fileName = "CollisionEvent")]
    public sealed class CollisionEvent : AtomEvent<Collision> { }
}
