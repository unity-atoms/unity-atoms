using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `string`. Inherits from `UnityEvent&lt;string, string&gt;`.
    /// </summary>
    [Serializable]
    public sealed class StringStringUnityEvent : UnityEvent<string, string> { }
}
