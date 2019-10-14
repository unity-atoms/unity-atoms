using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider", fileName = "ColliderEvent")]
    public sealed class ColliderEvent : AtomEvent<Collider> { }
}
