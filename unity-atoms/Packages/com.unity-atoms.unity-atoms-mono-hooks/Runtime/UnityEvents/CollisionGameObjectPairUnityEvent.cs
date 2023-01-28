using System;
using UnityEngine.Events;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// None generic Unity Event of type `CollisionGameObjectPair`. Inherits from `UnityEvent&lt;CollisionGameObjectPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionGameObjectPairUnityEvent : UnityEvent<CollisionGameObjectPair> { }
}
