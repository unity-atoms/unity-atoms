using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Color", fileName = "ColorConstant")]
    public sealed class ColorConstant : AtomBaseVariable<Color> { }
}
