using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Collider2DPair`. Inherits from `UnityEvent&lt;Collider2DPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DPairUnityEvent : UnityEvent<Collider2DPair> { }
}
