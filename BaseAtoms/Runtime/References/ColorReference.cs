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
    }
}
