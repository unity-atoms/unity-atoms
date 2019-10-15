using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `Collider2D`. Inherits from `AtomList&lt;Collider2D, Collider2DEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider2D", fileName = "Collider2DList")]
    public sealed class Collider2DList : AtomList<Collider2D, Collider2DEvent> { }
}
