using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// A struct representing a transition in a FSM.
    /// </summary>
    public struct FSMTransitionData
    {
        public string FromState { get; set; }
        public string ToState { get; set; }
        public string Command { get; set; }
        public BoolEvent CompleteTransition { get; set; }
    }
}