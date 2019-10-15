using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `Vector2`. Inherits from `UnityEvent&lt;Vector2, Vector2&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2Vector2UnityEvent : UnityEvent<Vector2, Vector2> { }
}
