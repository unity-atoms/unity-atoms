using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Collider2D`. Inherits from `AtomEvent&lt;Collider2D&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2D", fileName = "Collider2DEvent")]
    public sealed class Collider2DEvent : AtomEvent<Collider2D>
    {
    }
}
