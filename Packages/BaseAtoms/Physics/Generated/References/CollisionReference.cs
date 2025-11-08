using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityEngine.Collision`. Inherits from `AtomReference&lt;UnityEngine.Collision, CollisionPair, CollisionConstant, CollisionVariable, CollisionEvent, CollisionPairEvent, CollisionCollisionFunction, CollisionVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionReference : AtomReference<
        UnityEngine.Collision,
        CollisionPair,
        CollisionConstant,
        CollisionVariable,
        CollisionEvent,
        CollisionPairEvent,
        CollisionCollisionFunction,
        CollisionVariableInstancer>, IEquatable<CollisionReference>
    {
        public CollisionReference() : base() { }
        public CollisionReference(UnityEngine.Collision value) : base(value) { }
        public bool Equals(CollisionReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityEngine.Collision other)
        {
            throw new NotImplementedException();
        }
    }
}
