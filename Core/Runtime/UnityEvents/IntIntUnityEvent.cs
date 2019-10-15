using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `int`. Inherits from `UnityEvent&lt;int, int&gt;`.
    /// </summary>
    [Serializable]
    public sealed class IntIntUnityEvent : UnityEvent<int, int> { }
}
