using System;
using UnityEngine.Events;
using UnityAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Void`. Inherits from `UnityEvent&lt;Void&gt;`.
    /// </summary>
    [Serializable]
    public sealed class VoidUnityEvent : UnityEvent<Void> { }
}
