using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `Vector3`. Inherits from `AtomBaseVariable&lt;Vector3&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Vector3", fileName = "Vector3Constant")]
    public sealed class Vector3Constant : AtomBaseVariable<Vector3> { }
}
