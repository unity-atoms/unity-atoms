using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `float`. Inherits from `AtomEventReference&lt;float, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatEventReference : AtomEventReference<
        float,
        FloatVariable,
        FloatEvent,
        FloatFloatEvent,
        FloatFloatFunction,
        FloatVariableInstancer> { }
}
