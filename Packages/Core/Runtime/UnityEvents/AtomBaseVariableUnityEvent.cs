using System;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `AtomBaseVariable`. Inherits from `UnityEvent&lt;AtomBaseVariable&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AtomBaseVariableUnityEvent : UnityEvent<AtomBaseVariable> { }
}
