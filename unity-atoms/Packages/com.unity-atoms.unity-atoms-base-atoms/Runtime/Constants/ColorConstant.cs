using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `Color`. Inherits from `AtomBaseVariable&lt;Color&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Color", fileName = "ColorConstant")]
    public sealed class ColorConstant : AtomBaseVariable<Color> { }
}
