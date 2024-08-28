#if PACKAGE_UNITY_PHYSICS
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `Collider`. Inherits from `AtomBaseVariable&lt;Collider&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Collider", fileName = "ColliderConstant")]
    public sealed class ColliderConstant : AtomBaseVariable<Collider> { }
}
#endif
