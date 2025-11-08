using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UnityEngine.Collider2D`. Inherits from `AtomEvent&lt;UnityEngine.Collider2D&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider2D", fileName = "Collider2DEvent")]
    public sealed class Collider2DEvent : AtomEvent<UnityEngine.Collider2D>
    {
    }
}
