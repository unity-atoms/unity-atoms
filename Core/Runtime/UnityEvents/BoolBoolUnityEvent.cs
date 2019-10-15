using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event x 2 of type `bool`. Inherits from `UnityEvent&lt;bool, bool&gt;`.
    /// </summary>
    [Serializable]
    public sealed class BoolBoolUnityEvent : UnityEvent<bool, bool> { }
}
