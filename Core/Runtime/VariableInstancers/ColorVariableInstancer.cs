using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Color`. Inherits from `AtomVariableInstancer&lt;ColorVariable, Color, ColorEvent, ColorColorEvent, ColorColorFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Color Instancer")]
    public class ColorVariableInstancer : AtomVariableInstancer<ColorVariable, Color, ColorEvent, ColorColorEvent, ColorColorFunction> { }
}
