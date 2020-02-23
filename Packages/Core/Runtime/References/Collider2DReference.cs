using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Collider2D`. Inherits from `AtomReference&lt;Collider2D, Collider2DConstant, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DReference : AtomReference<
        Collider2D,
        Collider2DConstant,
        Collider2DVariable,
        Collider2DEvent,
        Collider2DCollider2DEvent,
        Collider2DCollider2DFunction,
        Collider2DVariableInstancer>
    {
        protected override bool ValueEquals(Collider2D other)
        {
            return (this.Value == null && other == null) || this.Value != null && other != null && this.Value == other;
        }
    }
}
