using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Color`. Inherits from `EquatableAtomReference&lt;Color, ColorPair, ColorConstant, ColorVariable, ColorEvent, ColorPairEvent, ColorColorFunction, ColorVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColorReference : EquatableAtomReference<
        Color,
        ColorPair,
        ColorConstant,
        ColorVariable,
        ColorEvent,
        ColorPairEvent,
        ColorColorFunction,
        ColorVariableInstancer>, IEquatable<ColorReference>
    {
        public ColorReference() : base() { }
        public ColorReference(Color value) : base(value) { }
        public bool Equals(ColorReference other) { return base.Equals(other); }
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
