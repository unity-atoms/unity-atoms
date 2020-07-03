using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtom
{
    /// <summary>
    /// None generic Unity Event of type `Collision`. Inherits from `UnityEvent&lt;Collision&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionUnityEvent : UnityEvent<Collision> { }
}
