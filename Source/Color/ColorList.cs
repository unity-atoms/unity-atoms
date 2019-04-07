using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Color/List", fileName = "ColorList", order = CreateAssetMenuUtils.Order.LIST)]
    public sealed class ColorList : ScriptableObjectList<Color, ColorEvent> { }
}
