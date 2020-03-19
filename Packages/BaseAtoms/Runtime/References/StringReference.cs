using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `string`. Inherits from `EquatableAtomReference&lt;string, StringPair, StringConstant, StringVariable, StringEvent, StringPairEvent, StringStringFunction, StringVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringReference : EquatableAtomReference<
        string,
        StringPair,
        StringConstant,
        StringVariable,
        StringEvent,
        StringPairEvent,
        StringStringFunction,
        StringVariableInstancer>, IEquatable<StringReference>
    {
        public StringReference() : base() { }
        public StringReference(string value) : base(value) { }
        public bool Equals(StringReference other) { return base.Equals(other); }
    }
}
