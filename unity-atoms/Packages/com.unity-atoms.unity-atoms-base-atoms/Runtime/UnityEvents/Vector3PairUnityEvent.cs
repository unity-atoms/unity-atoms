using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Vector3Pair`. Inherits from `UnityEvent&lt;Vector3Pair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3PairUnityEvent : UnityEvent<Vector3Pair> { }
}
