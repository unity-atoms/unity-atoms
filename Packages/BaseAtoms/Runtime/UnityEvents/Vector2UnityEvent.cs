using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Vector2`. Inherits from `UnityEvent&lt;Vector2&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2UnityEvent : UnityEvent<Vector2> { }
}
