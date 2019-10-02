using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Color", fileName = "ColorList")]
    public sealed class ColorList : AtomList<Color, ColorEvent> { }
}
