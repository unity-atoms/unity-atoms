using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Collider`. Inherits from `UnityEvent&lt;Collider&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderUnityEvent : UnityEvent<Collider> { }
}
