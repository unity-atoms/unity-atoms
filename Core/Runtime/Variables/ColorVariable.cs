using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Color`. Inherits from `EquatableAtomVariable&lt;Color, ColorEvent, ColorColorEvent, ColorColorFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Color", fileName = "ColorVariable")]
    public sealed class ColorVariable : EquatableAtomVariable<Color, ColorEvent, ColorColorEvent, ColorColorFunction>
    {
        /// <summary>
        /// Set Alpha of Color by value.
        /// </summary>
        /// <param name="value">New alpha value.</param>
        public void SetAlpha(float value) => Value = new Color(Value.r, Value.g, Value.b, value);

        /// <summary>
        /// Set Alpha of Color by Variable value.
        /// </summary>
        /// <param name="variable">New alpha Variable value.</param>
        public void SetAlpha(AtomBaseVariable<float> variable) => SetAlpha(variable.Value);
    }
}
