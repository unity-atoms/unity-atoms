using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 Reference of type `string`. Inherits from `AtomEventX2Reference&lt;string, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringStringEventReference : AtomEventX2Reference<
        string,
        StringVariable,
        StringEvent,
        StringStringEvent,
        StringStringFunction,
        StringVariableInstancer> { }
}
