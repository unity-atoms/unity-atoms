using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `float`. Inherits from `UnityEvent&lt;float&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatUnityEvent : UnityEvent<float> { }
}
