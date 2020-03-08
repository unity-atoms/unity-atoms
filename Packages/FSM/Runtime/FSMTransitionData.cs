using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    public struct FSMTransitionData
    {
        public string FromState { get; set; }
        public string ToState { get; set; }
        public string Command { get; set; }
        public BoolEvent CompleteTransition { get; set; }
    }
}