using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    [CreateAssetMenu(menuName = "Unity Atoms/FSM/Machine", fileName = "Machine")]
    public class FiniteStateMachine : StringVariable
    {
        public override string Value { get => _value; set => Dispatch(value); }

        /// <summary>
        /// Gets a boolean value indicating if the state machine is currently transitioning.
        /// </summary>
        public bool IsTransitioning { get => _currentTransition != null; }

        public BoolEvent CompleteCurrentTransition { get => _completeCurrentTransition; }

        public bool IsAtEndState
        {
            get
            {
                for (var i = 0; i < _transitions.Count; ++i)
                {
                    var transition = _transitions[i];
                    if (transition.FromState == Value)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        [SerializeField]
        private StringReference _initialState = default(StringReference);

        [SerializeField]
        private TransitionEvent _transitionStarted = default(TransitionEvent);

        [SerializeField]
        private BoolEvent _completeCurrentTransition = default(BoolEvent);


        [SerializeField]
        private List<Transition> _transitions;

        private bool _isUpdatingState = false;
        private Transition _currentTransition = null;
        private bool _resetOnNextTransitionCompleted = false;

        public void Begin()
        {
            if (!_resetOnNextTransitionCompleted && !IsTransitioning)
            {
                base.Reset(false);
            }
            else
            {
                _resetOnNextTransitionCompleted = true;
            }
        }

        /// <summary>
        /// Dispatches a new command to the FiniteStateMachine, invoking any necessary transitions.
        /// </summary>
        /// <param name="command"></param>
        public void Dispatch(string command)
        {
            // Commands dispatched during transition will be ignored
            if (IsTransitioning)
                return;

            var transition = FindTransitionForCurrentState(command);
            if (transition != null)
            {
                // Commands should not be dispatched in events listening to state changes of this machine
                if (_isUpdatingState)
                {
                    Debug.LogWarning("Do not call Dispatch from handlers listening to Changed and ChangedWithHistory events.");
                    return;
                }

                if (transition.TestCondition())
                {
                    _currentTransition = transition;
                    if (_transitionStarted != null)
                    {
                        _transitionStarted.Raise(
                            new TransitionData()
                            {
                                FromState = transition.FromState,
                                ToState = transition.ToState,
                                Command = transition.Command,
                                CompleteTransition = _completeCurrentTransition,
                            }
                        );
                    }
                    transition.Begin(this);
                }
            }
        }

        public void EndCurrentTransition()
        {
            _currentTransition = null;
            if (_resetOnNextTransitionCompleted)
            {
                Begin();
                return;
            }

            _isUpdatingState = true;
            base.Value = _currentTransition.ToState;
            _isUpdatingState = false;
        }

        private Transition FindTransitionForCurrentState(string command)
        {
            Transition ret = null;

            for (var i = 0; i < _transitions.Count; ++i)
            {
                var transition = _transitions[i];
                if (command == transition.Command && Value == transition.FromState)
                {
                    ret = transition;
                    break;
                }
            }

            return ret;
        }
    }
}