using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Color`. Inherits from `AtomVariableInstancer&lt;ColorVariable, ColorPair, Color, ColorEvent, ColorPairEvent, ColorColorFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Color Variable Instancer")]
    public class ColorVariableInstancer : AtomVariableInstancer<
        ColorVariable,
        ColorPair,
        Color,
        ColorEvent,
        ColorPairEvent,
        ColorColorFunction>
    { }
}
