using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `ColliderPair`. Inherits from `UnityEvent&lt;ColliderPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ColliderPairUnityEvent : UnityEvent<ColliderPair> { }
}
