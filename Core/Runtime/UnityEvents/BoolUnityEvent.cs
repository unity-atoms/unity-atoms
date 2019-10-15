using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `bool`. Inherits from `UnityEvent&lt;bool&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolUnityEvent : UnityEvent<bool> { }
}
