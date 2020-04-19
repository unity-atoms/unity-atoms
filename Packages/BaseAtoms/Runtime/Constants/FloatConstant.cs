using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `float`. Inherits from `AtomBaseVariable&lt;float&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Float", fileName = "FloatConstant")]
    public sealed class FloatConstant : AtomBaseVariable<float> { }
}
