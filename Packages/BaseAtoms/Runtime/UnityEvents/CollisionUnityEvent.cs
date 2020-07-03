using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Collision`. Inherits from `UnityEvent&lt;Collision&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionUnityEvent : UnityEvent<Collision> { }
}