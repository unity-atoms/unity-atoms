using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `Collider`. Inherits from `UnityEvent&lt;Collider, Collider&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderColliderUnityEvent : UnityEvent<Collider, Collider> { }
}
