using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 Reference of type `Collider2D`. Inherits from `AtomEventX2Reference&lt;Collider2D, Collider2DVariable, Collider2DEvent, Collider2DCollider2DEvent, Collider2DCollider2DFunction, Collider2DVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DCollider2DEventReference : AtomEventX2Reference<
        Collider2D,
        Collider2DVariable,
        Collider2DEvent,
        Collider2DCollider2DEvent,
        Collider2DCollider2DFunction,
        Collider2DVariableInstancer> { }
}
