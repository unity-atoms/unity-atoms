using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `int`. Inherits from `AtomEventReference&lt;int, IntVariable, IntEvent, IntVariableInstancer, IntEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntEventReference : AtomEventReference<
        int,
        IntVariable,
        IntEvent,
        IntVariableInstancer,
        IntEventInstancer>, IGetEvent 
    { }
}
