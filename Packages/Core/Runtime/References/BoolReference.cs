using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `bool`. Inherits from `EquatableAtomReference&lt;bool, BoolConstant, BoolVariable, BoolEvent, BoolBoolEvent, BoolBoolFunction, BoolVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolReference : EquatableAtomReference<
        bool,
        BoolConstant,
        BoolVariable,
        BoolEvent,
        BoolBoolEvent,
        BoolBoolFunction,
        BoolVariableInstancer>, IEquatable<BoolReference>
    {
        public BoolReference() : base() { }
        public BoolReference(bool value) : base(value) { }
        public bool Equals(BoolReference other) { return base.Equals(other); }
    }
}
