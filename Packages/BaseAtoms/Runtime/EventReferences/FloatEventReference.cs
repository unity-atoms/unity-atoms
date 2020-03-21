using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `float`. Inherits from `AtomEventReference&lt;float, FloatVariable, FloatEvent, FloatVariableInstancer, FloatEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatEventReference : AtomEventReference<
        float,
        FloatVariable,
        FloatEvent,
        FloatVariableInstancer,
        FloatEventInstancer>, IGetEvent 
    { }
}
