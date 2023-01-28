using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `string`. Inherits from `UnityEvent&lt;string&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringUnityEvent : UnityEvent<string> { }
}
