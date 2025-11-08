using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `UnityEngine.Collision`. Inherits from `UnityEvent&lt;UnityEngine.Collision&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionUnityEvent : UnityEvent<UnityEngine.Collision> { }
}
