using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UnityEngine.Collision2D`. Inherits from `AtomEvent&lt;UnityEngine.Collision2D&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collision2D", fileName = "Collision2DEvent")]
    public sealed class Collision2DEvent : AtomEvent<UnityEngine.Collision2D>
    {
    }
}
