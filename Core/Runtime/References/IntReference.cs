using System;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `int`. Inherits from `EquatableAtomReference&lt;int, IntConstant, IntVariable, IntEvent, IntIntEvent, IntIntFunction, IntVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntReference : EquatableAtomReference<
        int,
        IntConstant,
        IntVariable,
        IntEvent,
        IntIntEvent,
        IntIntFunction,
        IntVariableInstancer>, IEquatable<IntReference>
    {
        public IntReference() : base() { }
        public IntReference(int value) : base(value) { }
        public bool Equals(IntReference other) { return base.Equals(other); }
    }
}
