using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `GameObjectPair`. Inherits from `UnityEvent&lt;GameObjectPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectPairUnityEvent : UnityEvent<GameObjectPair> { }
}
