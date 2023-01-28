using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Vector2`. Inherits from `EquatableAtomReference&lt;Vector2, Vector2Pair, Vector2Constant, Vector2Variable, Vector2Event, Vector2PairEvent, Vector2Vector2Function, Vector2VariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2Reference : EquatableAtomReference<
        Vector2,
        Vector2Pair,
        Vector2Constant,
        Vector2Variable,
        Vector2Event,
        Vector2PairEvent,
        Vector2Vector2Function,
        Vector2VariableInstancer>, IEquatable<Vector2Reference>
    {
        public Vector2Reference() : base() { }
        public Vector2Reference(Vector2 value) : base(value) { }
        public bool Equals(Vector2Reference other) { return base.Equals(other); }
    }
}
