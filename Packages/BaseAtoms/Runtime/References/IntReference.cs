using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `int`. Inherits from `EquatableAtomReference&lt;int, IntPair, IntConstant, IntVariable, IntEvent, IntPairEvent, IntIntFunction, IntVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntReference : EquatableAtomReference<
        int,
        IntPair,
        IntConstant,
        IntVariable,
        IntEvent,
        IntPairEvent,
        IntIntFunction,
        IntVariableInstancer>, IEquatable<IntReference>
    {
        public IntReference() : base() { }
        public IntReference(int value) : base(value) { }
        public bool Equals(IntReference other) { return base.Equals(other); }
    }
}
