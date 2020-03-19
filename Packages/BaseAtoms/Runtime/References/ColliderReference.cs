using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Collider`. Inherits from `AtomReference&lt;Collider, ColliderPair, ColliderConstant, ColliderVariable, ColliderEvent, ColliderPairEvent, ColliderColliderFunction, ColliderVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderReference : AtomReference<
        Collider,
        ColliderPair,
        ColliderConstant,
        ColliderVariable,
        ColliderEvent,
        ColliderPairEvent,
        ColliderColliderFunction,
        ColliderVariableInstancer>, IEquatable<ColliderReference>
    {
        public ColliderReference() : base() { }
        public ColliderReference(Collider value) : base(value) { }
        public bool Equals(ColliderReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Collider other)
        {
            return (this.Value == null && other == null) || this.Value != null && other != null && this.Value == other;
        }
    }
}
