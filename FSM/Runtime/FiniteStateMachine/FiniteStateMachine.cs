using System;
using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms;

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
                return state != null && state.SubMachine != null ? state.SubMachine.Value : _value;
            }
            set => Dispatch(value);
        }
        public FSMTransitionDataEvent TransitionStarted { get => _transitionStarted; set => _transitionStarted = value; }
        public BoolEvent CompleteCurrentTransition { get => _completeCurrentTransition; set => _completeCurrentTransition = value; }
        public override string InitialValue { get => _states?.List != null && _states.List.Count > 0 ? _states.List[0].Id : ""; }

        /// <summary>
        /// Gets a boolean value indicating if the state machine is currently transitioning.
        /// </summary>
        public bool IsTransitioning { get => _currentTransition != null; }

        [SerializeField]
        private FSMTransitionDataEvent _transitionStarted = default(FSMTransitionDataEvent);

        [SerializeField]
        private BoolEvent _completeCurrentTransition = default(BoolEvent);

        [SerializeField]
        [AtomList]
        private FSMStateListWrapper _states;

        [SerializeField]
        [AtomList]
        private TransitionListWrapper _transitions;

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
            if (CompleteCurrentTransition != null && CompleteCurrentTransition.ReplayBufferSize > 0)
            {
                Debug.LogWarning("The Complete Current Transition event had a replay buffer size great than 0, which would cause unwanted behaviour. Setting it to 0 in order to avoid unexpected behaviour.");
                CompleteCurrentTransition.ReplayBufferSize = 0;
            }

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
            Validate();

            // Set all timers to the same as the cooldown
            for (var i = 0; i < _states.List.Count; ++i)
            {
                _states.List[i].Timer = _states.List[i].Cooldown;
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



        private void Validate()
        {
            for (var i = 0; i < _transitions.List.Count; ++i)
            {
                var transition = _transitions.List[i];
                if (!_states.List.Exists((s) => s.Id == transition.FromState))
                {
                    Debug.LogError($"Transition with From State {transition.FromState} can't be found in the defined states.");
                }
                if (!_states.List.Exists((s) => s.Id == transition.ToState))
                {
                    Debug.LogError($"Transition with To State {transition.ToState} can't be found in the defined states.");
                }
            }
        }

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
            for (var i = 0; i < _states.List.Count; ++i)
            {
                if (_states.List[i].SubMachine != null)
                {
                    _states.List[i].SubMachine.Reset();
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
            for (var i = 0; i < _states.List.Count; ++i)
            {
                var state = _states.List[i];
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

            for (var i = 0; i < _transitions.List.Count; ++i)
            {
                var transition = _transitions.List[i];
                if (command == transition.Command && _currentFlatValue == transition.FromState)
                {
                    return transition;
                }
            }

            return ret;
        }

        private FSMState GetState(string id)
        {
            for (var i = 0; i < _states.List.Count; ++i)
            {
                if (_states.List[i].Id == id)
                {
                    return _states.List[i];
                }
            }

            return null;
        }
    }
}