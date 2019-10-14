using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Color", fileName = "ColorList")]
    public sealed class ColorList : AtomList<Color, ColorEvent> { }
}
