using System;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Reference of type `Collision2DGameObject`. Inherits from `EquatableAtomReference&lt;Collision2DGameObject, Collision2DGameObjectPair, Collision2DGameObjectConstant, Collision2DGameObjectVariable, Collision2DGameObjectEvent, Collision2DGameObjectPairEvent, Collision2DGameObjectCollision2DGameObjectFunction, Collision2DGameObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collision2DGameObjectReference : EquatableAtomReference<
        Collision2DGameObject,
        Collision2DGameObjectPair,
        Collision2DGameObjectConstant,
        Collision2DGameObjectVariable,
        Collision2DGameObjectEvent,
        Collision2DGameObjectPairEvent,
        Collision2DGameObjectCollision2DGameObjectFunction,
        Collision2DGameObjectVariableInstancer>, IEquatable<Collision2DGameObjectReference>
    {
        public Collision2DGameObjectReference() : base() { }
        public Collision2DGameObjectReference(Collision2DGameObject value) : base(value) { }
        public bool Equals(Collision2DGameObjectReference other) { return base.Equals(other); }
    }
}
