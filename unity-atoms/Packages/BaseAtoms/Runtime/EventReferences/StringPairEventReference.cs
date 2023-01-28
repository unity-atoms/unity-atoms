using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `StringPair`. Inherits from `AtomEventReference&lt;StringPair, StringVariable, StringPairEvent, StringVariableInstancer, StringPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringPairEventReference : AtomEventReference<
        StringPair,
        StringVariable,
        StringPairEvent,
        StringVariableInstancer,
        StringPairEventInstancer>, IGetEvent 
    { }
}
