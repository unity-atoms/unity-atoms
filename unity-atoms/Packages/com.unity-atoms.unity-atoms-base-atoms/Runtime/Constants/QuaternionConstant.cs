using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `Quaternion`. Inherits from `AtomBaseVariable&lt;Quaternion&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Quaternion", fileName = "QuaternionConstant")]
    public sealed class QuaternionConstant : AtomBaseVariable<Quaternion> { }
}
