using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `IntPair`. Inherits from `AtomEventReference&lt;IntPair, IntVariable, IntPairEvent, IntVariableInstancer, IntPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntPairEventReference : AtomEventReference<
        IntPair,
        IntVariable,
        IntPairEvent,
        IntVariableInstancer,
        IntPairEventInstancer>, IGetEvent 
    { }
}
