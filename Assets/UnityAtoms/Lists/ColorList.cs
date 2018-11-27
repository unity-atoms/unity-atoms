using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Color", fileName = "ColorList", order = 3)]
    public class ColorList : ScriptableObjectList<Color, ColorEvent>
    {
    }
}