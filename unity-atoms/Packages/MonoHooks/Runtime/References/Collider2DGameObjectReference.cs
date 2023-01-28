using System;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Reference of type `Collider2DGameObject`. Inherits from `EquatableAtomReference&lt;Collider2DGameObject, Collider2DGameObjectPair, Collider2DGameObjectConstant, Collider2DGameObjectVariable, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectCollider2DGameObjectFunction, Collider2DGameObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DGameObjectReference : EquatableAtomReference<
        Collider2DGameObject,
        Collider2DGameObjectPair,
        Collider2DGameObjectConstant,
        Collider2DGameObjectVariable,
        Collider2DGameObjectEvent,
        Collider2DGameObjectPairEvent,
        Collider2DGameObjectCollider2DGameObjectFunction,
        Collider2DGameObjectVariableInstancer>, IEquatable<Collider2DGameObjectReference>
    {
        public Collider2DGameObjectReference() : base() { }
        public Collider2DGameObjectReference(Collider2DGameObject value) : base(value) { }
        public bool Equals(Collider2DGameObjectReference other) { return base.Equals(other); }
    }
}
