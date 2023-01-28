using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `BoolPair`. Inherits from `AtomEventReference&lt;BoolPair, BoolVariable, BoolPairEvent, BoolVariableInstancer, BoolPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolPairEventReference : AtomEventReference<
        BoolPair,
        BoolVariable,
        BoolPairEvent,
        BoolVariableInstancer,
        BoolPairEventInstancer>, IGetEvent 
    { }
}
