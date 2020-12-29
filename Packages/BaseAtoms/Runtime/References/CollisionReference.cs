using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `Collision`. Inherits from `AtomReference&lt;Collision, CollisionPair, CollisionConstant, CollisionVariable, CollisionEvent, CollisionPairEvent, CollisionCollisionFunction, CollisionVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionReference : AtomReference<
        Collision,
        CollisionPair,
        CollisionConstant,
        CollisionVariable,
        CollisionEvent,
        CollisionPairEvent,
        CollisionCollisionFunction,
        CollisionVariableInstancer>, IEquatable<CollisionReference>
    {
        public CollisionReference() : base() { }
        public CollisionReference(Collision value) : base(value) { }
        public bool Equals(CollisionReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Collision other)
        {
            return Value == other;
        }
    }
}
