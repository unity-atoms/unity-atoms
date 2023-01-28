using System;
using UnityEngine.Events;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// None generic Unity Event of type `FSMTransitionData`. Inherits from `UnityEvent&lt;FSMTransitionData&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FSMTransitionDataUnityEvent : UnityEvent<FSMTransitionData> { }
}
