using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `double`. Inherits from `UnityEvent&lt;double&gt;`.
    /// </summary>
    [Serializable]
    public sealed class DoubleUnityEvent : UnityEvent<double> { }
}
