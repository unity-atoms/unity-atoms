using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `string`. Inherits from `AtomEventReference&lt;string, StringVariable, StringEvent, StringVariableInstancer, StringEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringEventReference : AtomEventReference<
        string,
        StringVariable,
        StringEvent,
        StringVariableInstancer,
        StringEventInstancer>, IGetEvent 
    { }
}
