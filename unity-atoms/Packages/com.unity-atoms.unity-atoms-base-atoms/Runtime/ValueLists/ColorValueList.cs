using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Color`. Inherits from `AtomValueList&lt;Color, ColorEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Color", fileName = "ColorValueList")]
    public sealed class ColorValueList : AtomValueList<Color, ColorEvent> { }
}
