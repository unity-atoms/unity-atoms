using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `float`. Inherits from `AtomReference&lt;float, FloatConstant, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatReference : AtomReference<
        float,
        FloatConstant,
        FloatVariable,
        FloatEvent,
        FloatFloatEvent,
        FloatFloatFunction,
        FloatVariableInstancer> { }
}
