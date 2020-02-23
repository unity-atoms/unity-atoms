using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `string`. Inherits from `EquatableAtomReference&lt;string, StringConstant, StringVariable, StringEvent, StringStringEvent, StringStringFunction, StringVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringReference : EquatableAtomReference<
        string,
        StringConstant,
        StringVariable,
        StringEvent,
        StringStringEvent,
        StringStringFunction,
        StringVariableInstancer>, IEquatable<StringReference>
    {
        public bool Equals(StringReference other) { return base.Equals(other); }
    }
}
