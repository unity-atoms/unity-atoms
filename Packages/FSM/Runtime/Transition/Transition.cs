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
        private StringReference _fromState = default;

        [SerializeField]
        private StringReference _toState = default;

        [SerializeField]
        private StringReference _command = default;

        [SerializeField]
        private BoolVariable _testCondition = default;

        [SerializeField]
        private bool _raiseEventToCompleteTransition = default;

        private FiniteStateMachine _fsmReference;
        private Action<bool> _onComplete;


        private void Complete(bool completeTransition)
        {
            _onComplete(completeTransition);

            _fsmReference = null;
            _onComplete = null;
        }

        public void Begin(FiniteStateMachine fsm, Action<bool> onComplete)
        {
            _fsmReference = fsm;
            _onComplete = onComplete;

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

            Complete(completeTransition: true);
        }

        public void OnEventRaised(bool completeTransition)
        {
            _fsmReference.CompleteCurrentTransition.UnregisterListener(this);
            Complete(completeTransition);
        }

        public bool TestCondition() => _testCondition == null || _testCondition.Value;
    }
}