using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Color`. Inherits from `EquatableAtomVariable&lt;Color, ColorPair, ColorEvent, ColorPairEvent, ColorColorFunction&gt;`.
    /// </summary>


    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Color", fileName = "ColorVariable")]
    public sealed class ColorVariable : EquatableAtomVariable<Color, ColorPair, ColorEvent, ColorPairEvent, ColorColorFunction>
    {
    }
}
