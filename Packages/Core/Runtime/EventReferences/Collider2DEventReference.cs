using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Collider2D`. Inherits from `AtomEventReference&lt;Collider2D, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DEventReference : AtomEventReference<
        Collider2D,
        Collider2DVariable,
        Collider2DEvent,
        Collider2DCollider2DEvent,
        Collider2DCollider2DFunction,
        Collider2DVariableInstancer> { }
}
