using System;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Controls a transition from a FromState to a ToState.
    /// </summary>
    [Serializable]
    public class Transition : IAtomListener<bool>
    {
        public string FromState { get => _fromState.Value; }
        public string ToState { get => _toState.Value; }
        public string Command { get => _command.Value; }

        [SerializeField]
        private StringReference _fromState;

        [SerializeField]
        private StringReference _toState;

        [SerializeField]
        private StringReference _command;

        [SerializeField]
        private BoolVariable _testCondition;

        [SerializeField]
        private bool _raiseEventToCompleteTransition;

        private FiniteStateMachine _fsmReference;


        private void Complete()
        {
            _fsmReference.EndCurrentTransition();
        }

        public void Begin(FiniteStateMachine fsm)
        {
            _fsmReference = fsm;

            if (_raiseEventToCompleteTransition)
            {
                if (_fsmReference.CompleteCurrentTransition == null)
                {
                    Debug.LogWarning("Complete Current Transition on State Machine needs to pe specified when using Raise Event To Complete Transition. Ignoring and completing transition immediatly.");
                }
                else
                {
                    _fsmReference.CompleteCurrentTransition.RegisterListener(this);
                    return;
                }
            }

            Complete();
        }

        public void OnEventRaised(bool completeTransition)
        {
            if (completeTransition)
            {
                _fsmReference.CompleteCurrentTransition.UnregisterListener(this);
                Complete();
            }
        }

        public bool TestCondition() => _testCondition == null || _testCondition.Value;
    }
}