using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Color", fileName = "ColorConstant")]
    public sealed class ColorConstant : AtomBaseVariable<Color> { }
}
