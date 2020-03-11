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
        /// <summary>
        /// Get or set current value of this FSM. If a sub FSM is having the current state, then its state will be returned. Using the setter is the same thing as calling `Dispatch`. 
        /// </summary>
        /// <value>The command to issue.</value>
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
        public override string InitialValue { get => _states != null && _states.Count > 0 ? _states[0].Id : ""; }

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
        private bool _triggerEventsOnNextReset = false;
        private event Action<float, string> _onUpdate;
        private event Action<float, string> _onFixedUpdate;
        private event Action<string> _dispatchWhen;
        private event Action<string> _onStateCooldown;

        /// <summary>
        /// The value in this state machine, disregarding a "deeper" values in a sub machine.
        /// </summary>
        private string _currentFlatValue;

        private void Awake()
        {
            FiniteStateMachineMonoHook.GetInstance(createIfNotExist: true).OnUpdate -= OnUpdate;
            FiniteStateMachineMonoHook.GetInstance().OnUpdate += OnUpdate;

            FiniteStateMachineMonoHook.GetInstance().OnStart -= OnStart;
            FiniteStateMachineMonoHook.GetInstance().OnStart += OnStart;
        }

        private void OnDisable()
        {
            if (FiniteStateMachineMonoHook.GetInstance() != null)
            {
                FiniteStateMachineMonoHook.GetInstance().OnUpdate -= OnUpdate;
                FiniteStateMachineMonoHook.GetInstance().OnStart -= OnStart;
            }
            _onUpdate = null;
            _onFixedUpdate = null;
            _dispatchWhen = null;
            _onStateCooldown = null;
        }

        public void OnUpdate(Action<float, string> handler, GameObject gameObject)
        {
            Action<float, string> extendedHandler = null;
            extendedHandler = (deltaTime, state) =>
            {
                // Unregister created handler if original handler doesn't or if the GameObject has been destroyed
                if (handler == null || gameObject == null || !gameObject.scene.IsValid())
                {
                    _onUpdate -= extendedHandler;
                    return;
                }

                handler(deltaTime, state);
            };

            _onUpdate += extendedHandler;
        }

        public void OnFixedUpdate(Action<float, string> handler, GameObject gameObject)
        {
            Action<float, string> extendedHandler = null;
            extendedHandler = (deltaTime, state) =>
            {
                // Unregister created handler if original handler doesn't or if the GameObject has been destroyed
                if (handler == null || gameObject == null || !gameObject.scene.IsValid())
                {
                    _onFixedUpdate -= extendedHandler;
                    return;
                }

                handler(deltaTime, state);
            };

            _onFixedUpdate += extendedHandler;
        }

        public void DispatchWhen(string command, Func<string, bool> func, GameObject gameObject)
        {
            Action<string> extendedHandler = null;
            extendedHandler = (value) =>
            {
                // Unregister created handler if original handler doesn't or if the GameObject has been destroyed
                if (func == null || gameObject == null || !gameObject.scene.IsValid())
                {
                    _dispatchWhen -= extendedHandler;
                    return;
                }

                if (func(value))
                {
                    Dispatch(command);
                }
            };
            _dispatchWhen += extendedHandler;
        }

        public void OnStateCooldown(string state, Action<string> handler, GameObject gameObject)
        {
            Action<string> extendedHandler = null;
            extendedHandler = (value) =>
            {
                // Unregister created handler if original handler doesn't or if the GameObject has been destroyed
                if (handler == null || gameObject == null || !gameObject.scene.IsValid())
                {
                    _onStateCooldown -= extendedHandler;
                    return;
                }

                if (value == state)
                {
                    handler(value);
                }
            };

            _onStateCooldown += extendedHandler;
        }

        public override void Reset(bool shouldTriggerEvents = false)
        {
            // TODO: Validate transitions and states

            // Set all timers to the same as the cooldown
            for (var i = 0; i < _states.Count; ++i)
            {
                _states[i].Timer = _states[i].Cooldown;
            }

            if (!_resetOnNextTransitionCompleted && !IsTransitioning)
            {
                _resetOnNextTransitionCompleted = false;
                ResetAllSubMachines();
                base.Reset(shouldTriggerEvents);
                _currentFlatValue = _value;
            }
            else
            {
                _triggerEventsOnNextReset = shouldTriggerEvents;
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
                    transition.Begin(this, EndCurrentTransition);
                }
            }
            else
            {
                // State doesn't exist in this FSM, propagate down to all sub FSMs.
                var state = GetState(_currentFlatValue);
                if (state.SubMachine != null)
                {
                    state.SubMachine.Dispatch(command);
                }
            }
        }

        protected override bool ValueEquals(string other) => false; // Always trigger events even if changing to the same state as previous

        private void EndCurrentTransition()
        {
            if (_resetOnNextTransitionCompleted)
            {
                _resetOnNextTransitionCompleted = false;
                Reset(_triggerEventsOnNextReset);
                return;
            }

            _isUpdatingState = true;

            var toState = GetState(_currentTransition.ToState);
            if (toState.SubMachine != null)
            {
                // Reset sub machines in to state
                toState.SubMachine.Reset();
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

        private void ResetAllSubMachines()
        {
            for (var i = 0; i < _states.Count; ++i)
            {
                if (_states[i].SubMachine != null)
                {
                    _states[i].SubMachine.Reset();
                }
            }
        }

        private void OnStart()
        {
            Reset();
        }

        private void OnUpdate(float deltaTime)
        {
            // Update timers and call OnStateCooldown handlers if applicable
            var currentValue = Value;
            for (var i = 0; i < _states.Count; ++i)
            {
                var state = _states[i];
                if (state.Cooldown > 0f)
                {
                    var isCurrent = state.Id == currentValue;
                    var isOngoing = !isCurrent && state.Timer > 0f;

                    if (isCurrent || isOngoing)
                    {
                        if (isCurrent && state.Timer <= 0f && _onStateCooldown != null)
                        {
                            _onStateCooldown.Invoke(currentValue);
                        }

                        state.Timer += deltaTime;

                        if (state.Timer >= state.Cooldown)
                        {
                            state.Timer = 0f;
                        }
                    }
                }
            }

            // Call OnUpdate handlers
            if (_onUpdate != null)
            {
                _onUpdate.Invoke(deltaTime, currentValue);
            }
            // Call DispatchWhen handlers
            if (_dispatchWhen != null)
            {
                _dispatchWhen.Invoke(currentValue);
            }
        }

        private void OnFixedUpdate(float deltaTime)
        {
            // Call OnFixedUpdate handlers
            if (_onFixedUpdate != null)
            {
                _onFixedUpdate.Invoke(deltaTime, Value);
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