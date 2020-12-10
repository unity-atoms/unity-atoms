using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `DoublePair`. Inherits from `AtomEventReference&lt;DoublePair, DoubleVariable, DoublePairEvent, DoubleVariableInstancer, DoublePairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class DoublePairEventReference : AtomEventReference<
        DoublePair,
        DoubleVariable,
        DoublePairEvent,
        DoubleVariableInstancer,
        DoublePairEventInstancer>, IGetEvent 
    { }
}
