using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `GameObject`. Inherits from `AtomReference&lt;GameObject, GameObjectPair, GameObjectConstant, GameObjectVariable, GameObjectEvent, GameObjectPairEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectReference : AtomReference<
        GameObject,
        GameObjectPair,
        GameObjectConstant,
        GameObjectVariable,
        GameObjectEvent,
        GameObjectPairEvent,
        GameObjectGameObjectFunction,
        GameObjectVariableInstancer>, IEquatable<GameObjectReference>
    {
        public GameObjectReference() : base() { }
        public GameObjectReference(GameObject value) : base(value) { }
        public bool Equals(GameObjectReference other) { return base.Equals(other); }
        protected override bool ValueEquals(GameObject other)
        {
            return (this.Value == null && other == null) || this.Value != null && other != null && this.Value.GetInstanceID() == other.GetInstanceID();
        }
    }
}
