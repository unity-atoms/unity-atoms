using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Color`. Inherits from `EquatableAtomVariable&lt;Color, ColorEvent, ColorColorEvent, ColorColorFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Color", fileName = "ColorVariable")]
    public sealed class ColorVariable : EquatableAtomVariable<Color, ColorEvent, ColorColorEvent, ColorColorFunction> { }
}
