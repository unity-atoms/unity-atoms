using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Constant of type `int`. Inherits from `AtomBaseVariable&lt;int&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Int", fileName = "IntConstant")]
    public sealed class IntConstant : AtomBaseVariable<int> { }
}
