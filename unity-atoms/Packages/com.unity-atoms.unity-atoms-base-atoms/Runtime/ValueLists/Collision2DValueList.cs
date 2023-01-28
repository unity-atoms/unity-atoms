using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Collision2D`. Inherits from `AtomValueList&lt;Collision2D, Collision2DEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Collision2D", fileName = "Collision2DValueList")]
    public sealed class Collision2DValueList : AtomValueList<Collision2D, Collision2DEvent> { }
}
