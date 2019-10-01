using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider x 2", fileName = "ColliderColliderEvent")]
    public sealed class ColliderColliderEvent : AtomEvent<Collider, Collider> { }
}
