using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Collider2D`. Inherits from `AtomValueList&lt;Collider2D, Collider2DEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Collider2D", fileName = "Collider2DValueList")]
    public sealed class Collider2DValueList : AtomValueList<Collider2D, Collider2DEvent> { }
}
