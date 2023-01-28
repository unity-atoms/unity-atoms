using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `FloatPair`. Inherits from `AtomEventReference&lt;FloatPair, FloatVariable, FloatPairEvent, FloatVariableInstancer, FloatPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatPairEventReference : AtomEventReference<
        FloatPair,
        FloatVariable,
        FloatPairEvent,
        FloatVariableInstancer,
        FloatPairEventInstancer>, IGetEvent 
    { }
}
