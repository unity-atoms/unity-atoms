using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `UnityEngine.Collider`. Inherits from `UnityEvent&lt;UnityEngine.Collider&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderUnityEvent : UnityEvent<UnityEngine.Collider> { }
}
