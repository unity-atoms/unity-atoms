using System;
using UnityEngine.Events;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// None generic Unity Event of type `ColliderGameObjectPair`. Inherits from `UnityEvent&lt;ColliderGameObjectPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderGameObjectPairUnityEvent : UnityEvent<ColliderGameObjectPair> { }
}
