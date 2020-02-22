using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Collider`. Inherits from `AtomReference&lt;Collider, ColliderConstant, ColliderVariable, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction, ColliderVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderReference : AtomReference<
        Collider,
        ColliderConstant,
        ColliderVariable,
        ColliderEvent,
        ColliderColliderEvent,
        ColliderColliderFunction,
        ColliderVariableInstancer>
    {
        protected override bool ValueEquals(Collider other)
        {
            return (this.Value == null && other == null) || this.Value != null && other != null && this.Value == other;
        }
    }
}
