using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Vector2Pair`. Inherits from `UnityEvent&lt;Vector2Pair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2PairUnityEvent : UnityEvent<Vector2Pair> { }
}
