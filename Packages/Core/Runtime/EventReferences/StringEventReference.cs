using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `string`. Inherits from `AtomEventReference&lt;string, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringEventReference : AtomEventReference<
        string,
        StringVariable,
        StringEvent,
        StringStringEvent,
        StringStringFunction,
        StringVariableInstancer> { }
}
