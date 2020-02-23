using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `float`. Inherits from `EquatableAtomReference&lt;float, FloatConstant, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatReference : EquatableAtomReference<
        float,
        FloatConstant,
        FloatVariable,
        FloatEvent,
        FloatFloatEvent,
        FloatFloatFunction,
        FloatVariableInstancer>, IEquatable<FloatReference>
    {
        public bool Equals(FloatReference other) { return base.Equals(other); }
    }
}
