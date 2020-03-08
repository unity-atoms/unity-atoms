using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    [EditorIcon("atom-icon-delicate")]
    [CreateAssetMenu(menuName = "Unity Atoms/FSM/Finite State Machine", fileName = "FiniteStateMachine")]
    public class FiniteStateMachine : StringVariable
    {
        public override string Value { get => _value; set => Dispatch(value); }
        public StringReference InitialState { get => _initialState; }
        public FSMTransitionDataEvent TransitionStarted { get => _transitionStarted; set => _transitionStarted = value; }
        public BoolEvent CompleteCurrentTransition { get => _completeCurrentTransition; set => _completeCurrentTransition = value; }
        public override string InitialValue { get => _initialState.Value; }

        /// <summary>
        /// Gets a boolean value indicating if the state machine is currently transitioning.
        /// </summary>
        public bool IsTransitioning { get => _currentTransition != null; }

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
        private FSMTransitionDataEvent _transitionStarted = default(FSMTransitionDataEvent);

        [SerializeField]
        private BoolEvent _completeCurrentTransition = default(BoolEvent);


        [SerializeField]
        private List<Transition> _transitions;

        private bool _isUpdatingState = false;
        private Transition _currentTransition = null;
        private bool _resetOnNextTransitionCompleted = false;

        public void Begin()
        {
            _currentTransition = null;
            if (!_resetOnNextTransitionCompleted && !IsTransitioning)
            {
                _resetOnNextTransitionCompleted = false;
                base.Reset(false);
            }
            else
            {
                Debug.Log("Asdf");
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
                            new FSMTransitionData()
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
            if (_resetOnNextTransitionCompleted)
            {
                _resetOnNextTransitionCompleted = false;
                Begin();
                return;
            }

            _isUpdatingState = true;
            Debug.Log("Updating to " + _currentTransition.ToState);
            base.Value = _currentTransition.ToState;
            _currentTransition = null;
            _isUpdatingState = false;
        }

        private Transition FindTransitionForCurrentState(string command)
        {
            Transition ret = null;

            for (var i = 0; i < _transitions.Count; ++i)
            {
                var transition = _transitions[i];
                // Debug.Log($"Command {command} - From State {transition.FromState}. Current State {Value}.");
                if (command == transition.Command && Value == transition.FromState)
                {
                    return transition;
                }
            }

            return ret;
        }
    }
}