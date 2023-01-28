using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `string`. Inherits from `AtomBaseVariable&lt;string&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/String", fileName = "StringConstant")]
    public sealed class StringConstant : AtomBaseVariable<string> { }
}
