using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Collision2D`. Inherits from `UnityEvent&lt;Collision2D&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collision2DUnityEvent : UnityEvent<Collision2D> { }
}