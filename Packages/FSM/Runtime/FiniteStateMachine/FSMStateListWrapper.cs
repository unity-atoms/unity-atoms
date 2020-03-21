using System;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Needed in order to use our custom property drawer for states in the FSM.
    /// </summary>
    [Serializable]
    public class FSMStateListWrapper : AtomListWrapper<FSMState> { }
}