using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `double`. Inherits from `EquatableAtomReference&lt;double, DoublePair, DoubleConstant, DoubleVariable, DoubleEvent, DoublePairEvent, DoubleDoubleFunction, DoubleVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class DoubleReference : EquatableAtomReference<
        double,
        DoublePair,
        DoubleConstant,
        DoubleVariable,
        DoubleEvent,
        DoublePairEvent,
        DoubleDoubleFunction,
        DoubleVariableInstancer>, IEquatable<DoubleReference>
    {
        public DoubleReference() : base() { }
        public DoubleReference(double value) : base(value) { }
        public bool Equals(DoubleReference other) { return base.Equals(other); }
    }
}
