using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2D x 2", fileName = "Collider2DCollider2DEvent")]
    public sealed class Collider2DCollider2DEvent : AtomEvent<Collider2D, Collider2D> { }
}
