using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `Collider2D`. Inherits from `AtomBaseVariable&lt;Collider2D&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Collider2D", fileName = "Collider2DConstant")]
    public sealed class Collider2DConstant : AtomBaseVariable<Collider2D> { }
}
