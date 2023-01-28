using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Collision2DPair`. Inherits from `UnityEvent&lt;Collision2DPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collision2DPairUnityEvent : UnityEvent<Collision2DPair> { }
}
