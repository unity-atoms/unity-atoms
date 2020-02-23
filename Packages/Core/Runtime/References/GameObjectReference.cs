using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `GameObject`. Inherits from `AtomReference&lt;GameObject, GameObjectConstant, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectReference : AtomReference<
        GameObject,
        GameObjectConstant,
        GameObjectVariable,
        GameObjectEvent,
        GameObjectGameObjectEvent,
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
