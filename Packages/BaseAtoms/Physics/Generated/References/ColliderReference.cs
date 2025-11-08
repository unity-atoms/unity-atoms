using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityEngine.Collider`. Inherits from `AtomReference&lt;UnityEngine.Collider, ColliderPair, ColliderConstant, ColliderVariable, ColliderEvent, ColliderPairEvent, ColliderColliderFunction, ColliderVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderReference : AtomReference<
        UnityEngine.Collider,
        ColliderPair,
        ColliderConstant,
        ColliderVariable,
        ColliderEvent,
        ColliderPairEvent,
        ColliderColliderFunction,
        ColliderVariableInstancer>, IEquatable<ColliderReference>
    {
        public ColliderReference() : base() { }
        public ColliderReference(UnityEngine.Collider value) : base(value) { }
        public bool Equals(ColliderReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityEngine.Collider other)
        {
            throw new NotImplementedException();
        }
    }
}
