using System;
using UnityEngine;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Different Event Reference usages.
    /// </summary>
    public class FSMTransitionDataBaseEventReferenceUsage
    {
        public const int FSM = 2;
        public const int FSM_INSTANCER = 3;
    }
    /// <summary>
    /// Event Reference of type `FSMTransitionData`. Inherits from `AtomBaseEventReference&lt;FSMTransitionData, FSMTransitionDataEvent, FSMTransitionDataEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class FSMTransitionDataBaseEventReference : AtomBaseEventReference<
        FSMTransitionData,
        FSMTransitionDataEvent,
        FSMTransitionDataEventInstancer>, IGetEvent
    {
        /// <summary>
        /// Get the value for the Reference.
        /// </summary>
        /// <value>The value of type `FiniteStateMachine`.</value>
        public override FSMTransitionDataEvent Event
        {
            get
            {
                switch (_usage)
                {
                    case (FSMTransitionDataBaseEventReferenceUsage.FSM_INSTANCER): return ((FiniteStateMachine)_fsmInstancer.Variable).TransitionStarted;
                    case (FSMTransitionDataBaseEventReferenceUsage.FSM): return _fsm.TransitionStarted;
                    default:
                        return base.Event;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (FSMTransitionDataBaseEventReferenceUsage.FSM_INSTANCER):
                        ((FiniteStateMachine)_fsmInstancer.Variable).TransitionStarted = value;
                        break;
                    case (FSMTransitionDataBaseEventReferenceUsage.FSM):
                        _fsm.TransitionStarted = value;
                        break;
                    default:
                        base.Event = value;
                        break;
                }
            }
        }

        /// <summary>
        /// Takes event from this FiniteStateMachine if `Usage` is set to `FSM`.
        /// </summary>
        [SerializeField]
        private FiniteStateMachine _fsm = default(FiniteStateMachine);

        /// <summary>
        /// Takes event from this FiniteStateMachineInstancer if `Usage` is set to `FSM Instancer`.
        /// </summary>
        [SerializeField]
        private FiniteStateMachineInstancer _fsmInstancer = default(FiniteStateMachineInstancer);
    }
}
