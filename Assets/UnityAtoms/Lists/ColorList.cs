using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Color")]
    public class ColorList : ScriptableObjectList<Color, ColorEvent> { }
}