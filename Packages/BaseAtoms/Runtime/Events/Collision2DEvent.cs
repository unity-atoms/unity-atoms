using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Collision2D`. Inherits from `AtomEvent&lt;Collision2D&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collision2D", fileName = "Collision2DEvent")]
    public sealed class Collision2DEvent : AtomEvent<Collision2D>
    {
    }
}
