using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `Collider2D`. Inherits from `UnityEvent&lt;Collider2D, Collider2D&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DCollider2DUnityEvent : UnityEvent<Collider2D, Collider2D> { }
}
