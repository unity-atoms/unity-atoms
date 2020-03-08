using System;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{

    public class FiniteStateMachineReferenceUsage
    {
        public const int MACHINE = 0;
        public const int MACHINE_INSTANCER = 1;
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
                    case (FiniteStateMachineReferenceUsage.MACHINE_INSTANCER): return _machineInstancer == null ? default(FiniteStateMachine) : _machineInstancer.Variable;
                    case (FiniteStateMachineReferenceUsage.MACHINE):
                    default:
                        return _machine;
                }
            }
        }

        /// <summary>
        /// Variable used if `Usage` is set to `Variable`.
        /// </summary>
        [SerializeField]
        private FiniteStateMachine _machine = default(FiniteStateMachine);

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `VariableInstancer`.
        /// </summary>
        [SerializeField]
        private FiniteStateMachineInstancer _machineInstancer = default(FiniteStateMachineInstancer);
    }
}
