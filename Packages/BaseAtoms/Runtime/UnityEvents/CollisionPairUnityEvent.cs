using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `CollisionPair`. Inherits from `UnityEvent&lt;CollisionPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class CollisionPairUnityEvent : UnityEvent<CollisionPair> { }
}