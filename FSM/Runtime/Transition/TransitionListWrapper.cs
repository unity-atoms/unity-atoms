using System;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Needed in order to use our custom property drawer for transitions in the FSM.
    /// </summary>
    [Serializable]
    public class TransitionListWrapper : AtomListWrapper<Transition> { }
}