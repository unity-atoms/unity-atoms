using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `bool`. Inherits from `AtomBaseVariable&lt;bool&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Bool", fileName = "BoolConstant")]
    public sealed class BoolConstant : AtomBaseVariable<bool> { }
}
