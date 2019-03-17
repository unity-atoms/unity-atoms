using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Color/List", fileName = "ColorList", order = CreateAssetMenuUtils.Order.LIST)]
    public class ColorList : ScriptableObjectList<Color, ColorEvent> { }
}