using System;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Event Reference of type `FSMTransitionData`. Inherits from `AtomBaseEventReference&lt;FSMTransitionData, FSMTransitionDataEvent, FSMTransitionDataEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FSMTransitionDataBaseEventReference : AtomBaseEventReference<
        FSMTransitionData,
        FSMTransitionDataEvent,
        FSMTransitionDataEventInstancer>, IGetEvent
    { }
}
