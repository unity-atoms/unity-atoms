using System;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Different usages of the FSM reference.
    /// </summary>
    public class FiniteStateMachineReferenceUsage
    {
        public const int FSM = 0;
        public const int FSM_INSTANCER = 1;
    }

    /// <summary>
    /// Reference of type `FiniteStateMachine`. Inherits from `AtomBaseReference`.
    /// </summary>
    [Serializable]
    public class FiniteStateMachineReference : AtomBaseReference
    {
        /// <summary>
        /// Get the value for the Reference.
        /// </summary>
        /// <value>The value of type `FiniteStateMachine`.</value>
        public FiniteStateMachine Machine
        {
            get
            {
                switch (_usage)
                {
                    case (FiniteStateMachineReferenceUsage.FSM_INSTANCER):
                        return _fsmInstancer == null ? default(FiniteStateMachine) : (FiniteStateMachine)_fsmInstancer.Variable;
                    case (FiniteStateMachineReferenceUsage.FSM):
                    default:
                        return _fsm;
                }
            }
        }

        /// <summary>
        /// Variable used if `Usage` is set to `FSM`.
        /// </summary>
        [SerializeField]
        private FiniteStateMachine _fsm = default(FiniteStateMachine);

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `FSM_INSTANCER`.
        /// </summary>
        [SerializeField]
        private FiniteStateMachineInstancer _fsmInstancer = default(FiniteStateMachineInstancer);
    }
}
