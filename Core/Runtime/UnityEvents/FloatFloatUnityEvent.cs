using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `float`. Inherits from `UnityEvent&lt;float, float&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FloatFloatUnityEvent : UnityEvent<float, float> { }
}
