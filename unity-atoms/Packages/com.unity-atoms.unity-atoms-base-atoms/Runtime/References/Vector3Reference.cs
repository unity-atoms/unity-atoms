using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Vector3`. Inherits from `EquatableAtomReference&lt;Vector3, Vector3Pair, Vector3Constant, Vector3Variable, Vector3Event, Vector3PairEvent, Vector3Vector3Function, Vector3VariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3Reference : EquatableAtomReference<
        Vector3,
        Vector3Pair,
        Vector3Constant,
        Vector3Variable,
        Vector3Event,
        Vector3PairEvent,
        Vector3Vector3Function,
        Vector3VariableInstancer>, IEquatable<Vector3Reference>
    {
        public Vector3Reference() : base() { }
        public Vector3Reference(Vector3 value) : base(value) { }
        public bool Equals(Vector3Reference other) { return base.Equals(other); }
    }
}
