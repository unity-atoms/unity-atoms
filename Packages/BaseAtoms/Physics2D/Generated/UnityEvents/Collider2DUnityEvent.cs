using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `UnityEngine.Collider2D`. Inherits from `UnityEvent&lt;UnityEngine.Collider2D&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DUnityEvent : UnityEvent<UnityEngine.Collider2D> { }
}
