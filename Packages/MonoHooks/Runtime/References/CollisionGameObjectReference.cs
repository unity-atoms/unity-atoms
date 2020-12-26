using System;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Reference of type `CollisionGameObject`. Inherits from `EquatableAtomReference&lt;CollisionGameObject, CollisionGameObjectPair, CollisionGameObjectConstant, CollisionGameObjectVariable, CollisionGameObjectEvent, CollisionGameObjectPairEvent, CollisionGameObjectCollisionGameObjectFunction, CollisionGameObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionGameObjectReference : EquatableAtomReference<
        CollisionGameObject,
        CollisionGameObjectPair,
        CollisionGameObjectConstant,
        CollisionGameObjectVariable,
        CollisionGameObjectEvent,
        CollisionGameObjectPairEvent,
        CollisionGameObjectCollisionGameObjectFunction,
        CollisionGameObjectVariableInstancer>, IEquatable<CollisionGameObjectReference>
    {
        public CollisionGameObjectReference() : base() { }
        public CollisionGameObjectReference(CollisionGameObject value) : base(value) { }
        public bool Equals(CollisionGameObjectReference other) { return base.Equals(other); }
    }
}
