using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `Color`. Inherits from `AtomList&lt;Color, ColorEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Color", fileName = "ColorList")]
    public sealed class ColorList : AtomList<Color, ColorEvent> { }
}
