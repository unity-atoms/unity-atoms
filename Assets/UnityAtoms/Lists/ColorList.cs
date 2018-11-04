using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Lists/Color")]
    public class ColorList : ScriptableObjectList<Color, ColorEvent> { }
}