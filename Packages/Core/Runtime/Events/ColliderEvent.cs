using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider", fileName = "ColliderEvent")]
    public sealed class ColliderEvent : AtomEvent<Collider> { }
}
