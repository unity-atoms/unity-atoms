using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `string`. Inherits from `AtomReference&lt;string, StringConstant, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringReference : AtomReference<
        string,
        StringConstant,
        StringVariable,
        StringEvent,
        StringStringEvent,
        StringStringFunction,
        StringVariableInstancer> { }
}
