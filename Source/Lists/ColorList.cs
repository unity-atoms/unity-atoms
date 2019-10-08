using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Color", fileName = "ColorList")]
    public sealed class ColorList : AtomList<Color, ColorEvent> { }
}
