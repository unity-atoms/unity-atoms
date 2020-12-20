using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `int`. Inherits from `UnityEvent&lt;int&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntUnityEvent : UnityEvent<int> { }
}
