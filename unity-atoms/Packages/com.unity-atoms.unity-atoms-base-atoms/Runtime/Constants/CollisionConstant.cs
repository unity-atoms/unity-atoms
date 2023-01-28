using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `Collision`. Inherits from `AtomBaseVariable&lt;Collision&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Collision", fileName = "CollisionConstant")]
    public sealed class CollisionConstant : AtomBaseVariable<Collision> { }
}
