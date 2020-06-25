using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Collider2D`. Inherits from `UnityEvent&lt;Collider2D&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DUnityEvent : UnityEvent<Collider2D> { }
}
