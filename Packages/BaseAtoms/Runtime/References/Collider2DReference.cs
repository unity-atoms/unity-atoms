using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Collider2D`. Inherits from `AtomReference&lt;Collider2D, Collider2DPair, Collider2DConstant, Collider2DVariable, Collider2DEvent, Collider2DPairEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DReference : AtomReference<
        Collider2D,
        Collider2DPair,
        Collider2DConstant,
        Collider2DVariable,
        Collider2DEvent,
        Collider2DPairEvent,
        Collider2DCollider2DFunction,
        Collider2DVariableInstancer>, IEquatable<Collider2DReference>
    {
        public Collider2DReference() : base() { }
        public Collider2DReference(Collider2D value) : base(value) { }
        public bool Equals(Collider2DReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Collider2D other)
        {
            return (this.Value == null && other == null) || this.Value != null && other != null && this.Value == other;
        }
    }
}
