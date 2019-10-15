using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `Collider2D`. Inherits from `AtomEvent&lt;Collider2D, Collider2D&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2D x 2", fileName = "Collider2DCollider2DEvent")]
    public sealed class Collider2DCollider2DEvent : AtomEvent<Collider2D, Collider2D> { }
}
