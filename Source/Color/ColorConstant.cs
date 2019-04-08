using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Color/Constant", fileName = "ColorConstant", order = CreateAssetMenuUtils.Order.CONSTANT)]
    public sealed class ColorConstant : ScriptableObjectVariableBase<Color> { }
}
