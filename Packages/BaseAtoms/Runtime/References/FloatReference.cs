using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `float`. Inherits from `EquatableAtomReference&lt;float, FloatPair, FloatConstant, FloatVariable, FloatEvent, FloatPairEvent, FloatFloatFunction, FloatVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatReference : EquatableAtomReference<
        float,
        FloatPair,
        FloatConstant,
        FloatVariable,
        FloatEvent,
        FloatPairEvent,
        FloatFloatFunction,
        FloatVariableInstancer,
        AtomCollection,
        AtomList>, IEquatable<FloatReference>
    {
        public FloatReference() : base() { }
        public FloatReference(float value) : base(value) { }
        public bool Equals(FloatReference other) { return base.Equals(other); }
    }
}
