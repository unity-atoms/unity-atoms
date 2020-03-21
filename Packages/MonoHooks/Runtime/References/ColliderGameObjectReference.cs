using System;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Reference of type `ColliderGameObject`. Inherits from `EquatableAtomReference&lt;ColliderGameObject, ColliderGameObjectPair, ColliderGameObjectConstant, ColliderGameObjectVariable, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectColliderGameObjectFunction, ColliderGameObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderGameObjectReference : EquatableAtomReference<
        ColliderGameObject,
        ColliderGameObjectPair,
        ColliderGameObjectConstant,
        ColliderGameObjectVariable,
        ColliderGameObjectEvent,
        ColliderGameObjectPairEvent,
        ColliderGameObjectColliderGameObjectFunction,
        ColliderGameObjectVariableInstancer>, IEquatable<ColliderGameObjectReference>
    {
        public ColliderGameObjectReference() : base() { }
        public ColliderGameObjectReference(ColliderGameObject value) : base(value) { }
        public bool Equals(ColliderGameObjectReference other) { return base.Equals(other); }
    }
}
