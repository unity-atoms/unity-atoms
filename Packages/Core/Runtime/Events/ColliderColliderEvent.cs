using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider x 2", fileName = "ColliderColliderEvent")]
    public sealed class ColliderColliderEvent : AtomEvent<Collider, Collider> { }
}
