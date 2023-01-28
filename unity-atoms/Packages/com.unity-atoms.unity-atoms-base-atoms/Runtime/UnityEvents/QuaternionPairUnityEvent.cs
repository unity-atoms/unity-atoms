using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `QuaternionPair`. Inherits from `UnityEvent&lt;QuaternionPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class QuaternionPairUnityEvent : UnityEvent<QuaternionPair> { }
}
