using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `Vector3`. Inherits from `UnityEvent&lt;Vector3, Vector3&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3Vector3UnityEvent : UnityEvent<Vector3, Vector3> { }
}
