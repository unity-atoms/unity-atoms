using System;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    [EditorIcon("atom-icon-delicate")]
    [CreateAssetMenu(menuName = "Unity Atoms/FSM/Finite State Machine", fileName = "FiniteStateMachine")]
    public class FiniteStateMachine : StringVariable
    {
        public override string Value
        {
            get
            {
                var state = GetState(_value);
                return state.SubMachine != null ? state.SubMachine.Value : _value;
            }
            set => Dispatch(value);
        }
        public FSMTransitionDataEvent TransitionStarted { get => _transitionStarted; set => _transitionStarted = value; }
        public BoolEvent CompleteCurrentTransition { get => _completeCurrentTransition; set => _completeCurrentTransition = value; }
        public override string InitialValue { get => _states.Count > 0 ? _states[0].Id : ""; }

        /// <summary>
        /// Gets a boolean value indicating if the state machine is currently transitioning.
        /// </summary>
        public bool IsTransitioning { get => _currentTransition != null; }


        [SerializeField]
        private FSMTransitionDataEvent _transitionStarted = default(FSMTransitionDataEvent);

        [SerializeField]
        private BoolEvent _completeCurrentTransition = default(BoolEvent);

        [SerializeField]
        private List<FSMState> _states;

        [SerializeField]
        private List<Transition> _transitions;

        private bool _isUpdatingState = false;
        private Transition _currentTransition = null;
        private bool _resetOnNextTransitionCompleted = false;
        private event Action<float, string> _onUpdate;
        private event Action<string> _dispatchWhen;

        /// <summary>
        /// The value in this state machine, disregarding a "deeper" values in a sub machine.
        /// </summary>
        private string _currentFlatValue;

        private void OnDisable()
        {
            if (FiniteStateMachineUpdateHook.GetInstance() != null)
            {
                FiniteStateMachineUpdateHook.GetInstance().OnUpdate -= UpdateTick;
            }
            _onUpdate = null;
            _dispatchWhen = null;
        }

        public void OnUpdate(Action<float, string> handler)
        {
            _onUpdate += handler;
        }

        public void DispatchWhen(string command, Func<string, bool> func)
        {
            _dispatchWhen += (value) =>
            {
                if (func(value))
                {
                    Dispatch(command);
                }
            };
        }

        public void Begin()
        {
            FiniteStateMachineUpdateHook.GetInstance(createIfNotExist: true).OnUpdate -= UpdateTick;
            FiniteStateMachineUpdateHook.GetInstance().OnUpdate += UpdateTick;

            if (!_resetOnNextTransitionCompleted && !IsTransitioning)
            {
                _resetOnNextTransitionCompleted = false;
                ResetAllSubMachines();
                base.Reset(false);
                _currentFlatValue = _value;
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
            else
            {
                var state = GetState(_currentFlatValue);
                if (state.SubMachine != null)
                {
                    state.SubMachine.Dispatch(command);
                }
            }
        }

        protected override bool ValueEquals(string other) => false;

        public void EndCurrentTransition()
        {
            if (_resetOnNextTransitionCompleted)
            {
                _resetOnNextTransitionCompleted = false;
                Begin();
                return;
            }

            _isUpdatingState = true;

            var toState = GetState(_currentTransition.ToState);
            if (toState.SubMachine != null)
            {
                // Reset sub machines in to state
                toState.SubMachine.Begin();
                base.Value = toState.SubMachine.Value;
            }
            else
            {
                base.Value = _currentTransition.ToState;
            }
            _currentFlatValue = _currentTransition.ToState;
            _currentTransition = null;

            _isUpdatingState = false;
        }

        public void ResetAllSubMachines()
        {
            for (var i = 0; i < _states.Count; ++i)
            {
                if (_states[i].SubMachine != null)
                {
                    _states[i].SubMachine.Begin();
                }
            }
        }

        private void UpdateTick(float deltaTime)
        {
            // Update timers
            var currentValue = Value;
            for (var i = 0; i < _states.Count; ++i)
            {
                var state = _states[i];
                if (state.Duration > 0f)
                {
                    var isCurrent = state.Id == currentValue;
                    var isOngoing = !isCurrent && state.Timer > 0f;

                    if (isCurrent || isOngoing)
                    {
                        state.Timer += deltaTime;

                        if (state.Timer > state.Duration)
                        {
                            if (isCurrent)
                            {
                                base.Value = currentValue; // Will trigger Changed event
                            }

                            state.Timer = 0f;
                        }
                    }
                }
            }

            // Call OnUpdate hooks
            if (_onUpdate != null)
            {
                _onUpdate.Invoke(deltaTime, currentValue);
            }
            if (_dispatchWhen != null)
            {
                _dispatchWhen.Invoke(currentValue);
            }
        }

        private Transition FindTransitionForCurrentState(string command)
        {
            Transition ret = null;

            for (var i = 0; i < _transitions.Count; ++i)
            {
                var transition = _transitions[i];
                if (command == transition.Command && _currentFlatValue == transition.FromState)
                {
                    return transition;
                }
            }

            return ret;
        }

        private FSMState GetState(string id)
        {
            for (var i = 0; i < _states.Count; ++i)
            {
                if (_states[i].Id == id)
                {
                    return _states[i];
                }
            }

            throw new System.Exception($"State with id {id} could not be found.");
        }
    }
}