using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Variables. Inherits from `AtomBaseVariable&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The Variable value type.</typeparam>
    /// <typeparam name="P">IPair of type `T`.</typeparam>
    /// <typeparam name="E1">Event of type `AtomEvent&lt;T&gt;`.</typeparam>
    /// <typeparam name="E2">Event of type `AtomEvent&lt;T, T&gt;`.</typeparam>
    /// <typeparam name="F">Function of type `FunctionEvent&lt;T, T&gt;`.</typeparam>
    [EditorIcon("atom-icon-lush")]
    public abstract class AtomVariable<T, P, E1, E2, F> : AtomBaseVariable<T>, IGetEvent, ISetEvent, IGetOrCreateEvent
        where P : struct, IPair<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
    {
        /// <summary>
        /// The Variable value as a property.
        /// </summary>
        /// <returns>Get or set the Variable's value.</returns>
        public override T Value { get => _value; set => SetValue(value); }

        /// <summary>
        /// The initial value as a property.
        /// </summary>
        /// <returns>Get the Variable's initial value.</returns>
        public virtual T InitialValue { get => _initialValue; set => _initialValue = value; }

        /// <summary>
        /// The value the Variable had before its value got changed last time.
        /// </summary>
        /// <value>Get the Variable's old value.</value>
        public T OldValue { get => _oldValue; }

        /// <summary>
        /// Changed Event triggered when the Variable value gets changed.
        /// </summary>
        [SerializeField]
        [FormerlySerializedAs("Changed")]
        private E1 _changed;
        public E1 Changed
        {
            get
            {
                GetOrCreateEvent<E1>();
                return _changed;
            }
            set
            {
                _changed = value;
            }
        }

        /// <summary>
        /// Changed with history Event triggered when the Variable value gets changed.
        /// </summary>
        [SerializeField]
        [FormerlySerializedAs("ChangedWithHistory")]
        private E2 _changedWithHistory;
        public E2 ChangedWithHistory
        {
            get
            {
                GetOrCreateEvent<E2>();
                return _changedWithHistory;
            }
            set
            {
                _changedWithHistory = value;
            }
        }

        /// <summary>
        /// Whether Changed Event should be triggered on OnEnable or not
        /// </summary>
        [SerializeField]
        private bool _triggerChangedOnOnEnable = default;

        /// <summary>
        /// Whether ChangedWithHistory Event should be triggered on OnEnable or not
        /// </summary>
        [SerializeField]
        private bool _triggerChangedWithHistoryOnOnEnable = default;

        [SerializeField]
        private T _oldValue;

        /// <summary>
        /// The inital value of the Variable.
        /// </summary>
        [SerializeField]
        private T _initialValue = default(T);

#if UNITY_EDITOR
        /// <summary>
        /// Set of all AtomVariable instances in editor.
        /// </summary>
        private static HashSet<AtomVariable<T, P, E1, E2, F>> _instances = new HashSet<AtomVariable<T, P, E1, E2, F>>();
#endif

        /// <summary>
        /// When setting the value of a Variable the new value will be piped through all the pre change transformers, which allows you to create custom logic and restriction on for example what values can be set for this Variable.
        /// </summary>
        /// <value>Get the list of pre change transformers.</value>
        public List<F> PreChangeTransformers
        {
            get => _preChangeTransformers;
            set
            {
                if (value == null)
                {
                    _preChangeTransformers.Clear();
                }
                else
                {
                    _preChangeTransformers = value;
                }
            }
        }

        [SerializeField]
        private List<F> _preChangeTransformers = new List<F>();

        protected abstract bool ValueEquals(T other);

        private void OnValidate()
        {
            InitialValue = RunPreChangeTransformers(InitialValue);
            _value = RunPreChangeTransformers(_value);
        }

        private void OnEnable()
        {
            SetInitialValues();
            TriggerInitialEvents();

#if UNITY_EDITOR
            if (EditorSettings.enterPlayModeOptionsEnabled)
            {
                _instances.Add(this);

                EditorApplication.playModeStateChanged -= HandlePlayModeStateChange;
                EditorApplication.playModeStateChanged += HandlePlayModeStateChange;
            }
#endif
        }


        /// <summary>
        /// Set initial values
        /// </summary>
        private void SetInitialValues()
        {
            _oldValue = InitialValue;
            _value = InitialValue;
        }

        /// <summary>
        /// Trigger initial events if related options enabled
        /// </summary>
        public void TriggerInitialEvents()
        {
            if (_triggerChangedOnOnEnable)
            {
                if (Changed == null)
                    GetOrCreateEvent<E1>();

                Changed.Raise(Value);
            }
            if (_triggerChangedWithHistoryOnOnEnable)
            {
                if (ChangedWithHistory == null)
                    GetOrCreateEvent<E2>();

                var pair = default(P);
                pair.Item1 = _value;
                pair.Item2 = _oldValue;
                ChangedWithHistory.Raise(pair);
            }
        }


#if UNITY_EDITOR
        private static void HandlePlayModeStateChange(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.ExitingEditMode)
            {
                foreach (var instance in _instances)
                {
                    instance.SetInitialValues();
                }
            }
            else if (state == PlayModeStateChange.EnteredPlayMode)
            {
                foreach (var instance in _instances)
                {
                    instance.TriggerInitialEvents();
                };
            }
        }
#endif

        /// <summary>
        /// Reset the Variable to its `_initialValue`.
        /// </summary>
        /// <param name="shouldTriggerEvents">Set to `true` if Events should be triggered on reset, otherwise `false`.</param>
        public override void Reset(bool shouldTriggerEvents = false)
        {
            if (!shouldTriggerEvents)
            {
                _oldValue = _value;
                _value = InitialValue;
            }
            else
            {
                SetValue(InitialValue);
            }
        }

        /// <summary>
        /// Set the Variable value.
        /// </summary>
        /// <param name="newValue">The new value to set.</param>
        /// <returns>`true` if the value got changed, otherwise `false`.</returns>
        public bool SetValue(T newValue, bool forceEvent = false)
        {
            var preProcessedNewValue = RunPreChangeTransformers(newValue);
            var changeValue = !ValueEquals(preProcessedNewValue);
            var triggerEvents = changeValue || forceEvent;

            if (changeValue)
            {
                _oldValue = _value;
                _value = preProcessedNewValue;
            }

            if (triggerEvents)
            {
                if (Changed != null) { Changed.Raise(_value); }
                if (ChangedWithHistory != null)
                {
                    // NOTE: Doing new P() here, even though it is cleaner, generates garbage.
                    var pair = default(P);
                    pair.Item1 = _value;
                    pair.Item2 = _oldValue;
                    ChangedWithHistory.Raise(pair);
                }
            }

            return changeValue;
        }

        /// <summary>
        /// Set the Variable value.
        /// </summary>
        /// <param name="variable">The value to set provided from another Variable.</param>
        /// <returns>`true` if the value got changed, otherwise `false`.</returns>
        public bool SetValue(AtomVariable<T, P, E1, E2, F> variable)
        {
            return SetValue(variable.Value);
        }

        #region Observable

        /// <summary>
        /// Turn the Variable's change Event into an `IObservable&lt;T&gt;`. Makes the Variable's change Event compatible with for example UniRx.
        /// </summary>
        /// <returns>The Variable's change Event as an `IObservable&lt;T&gt;`.</returns>
        public IObservable<T> ObserveChange()
        {
            if (Changed == null)
            {
                throw new Exception("You must assign a Changed event in order to observe variable changes.");
            }

            return new ObservableEvent<T>(Changed.Register, Changed.Unregister);
        }

        /// <summary>
        /// Turn the Variable's change with history Event into an `IObservable&lt;T, T&gt;`. Makes the Variable's change with history Event compatible with for example UniRx.
        /// </summary>
        /// <returns>The Variable's change Event as an `IObservable&lt;T, T&gt;`.</returns>
        public IObservable<P> ObserveChangeWithHistory()
        {
            if (ChangedWithHistory == null)
            {
                throw new Exception("You must assign a ChangedWithHistory event in order to observe variable changes.");
            }

            return new ObservableEvent<P>(ChangedWithHistory.Register, ChangedWithHistory.Unregister);
        }
        #endregion // Observable

        private T RunPreChangeTransformers(T value)
        {
            if (_preChangeTransformers.Count <= 0)
            {
                return value;
            }

            var preProcessedValue = value;
            for (var i = 0; i < _preChangeTransformers.Count; ++i)
            {
                var Transformer = _preChangeTransformers[i];
                if (Transformer != null)
                {
                    preProcessedValue = Transformer.Call(preProcessedValue);
                }
            }


            return preProcessedValue;
        }

        /// <summary>
        /// Get event by type (allowing inheritance).
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <returns>Changed - If Changed (or ChangedWithHistory) are of type E
        /// ChangedWithHistory - If not Changed but ChangedWithHistory is of type E
        /// <exception cref="NotSupportedException">if none of the events are of type E</exception>
        /// </returns>
        public E GetEvent<E>() where E : AtomEventBase
        {
            if (typeof(E) == typeof(E1))
            {
                return Changed as E;
            }
            if (typeof(E) == typeof(E2))
            {
                return ChangedWithHistory as E;
            }

            throw new NotSupportedException($"Event type {typeof(E)} not supported! Use {typeof(E1)} or {typeof(E2)}.");
        }

        /// <summary>
        /// Set event by type.
        /// </summary>
        /// <param name="e">The new event value.</param>
        /// <typeparam name="E"></typeparam>
        public void SetEvent<E>(E e) where E : AtomEventBase
        {
            if (typeof(E) == typeof(E1))
            {
                Changed = (e as E1);
                return;
            }
            if (typeof(E) == typeof(E2))
            {
                ChangedWithHistory = (e as E2);
                return;
            }

            throw new Exception($"Event type {typeof(E)} not supported! Use {typeof(E1)} or {typeof(E2)}.");
        }

        /// <summary>
        /// Get event by type (allowing inheritance). Creates an event if the type is supported for this Variable, but the Event itself is `null`.
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <returns>Changed - If Changed (or ChangedWithHistory) are of type E
        /// ChangedWithHistory - If not Changed but ChangedWithHistory is of type E
        /// <exception cref="NotSupportedException">if none of the events are of type E</exception>
        /// </returns>
        public E GetOrCreateEvent<E>() where E : AtomEventBase
        {
            if (typeof(E) == typeof(E1))
            {
                if (_changed == null)
                {
                    _changed = ScriptableObject.CreateInstance<E1>();
                    _changed.name = $"{(String.IsNullOrWhiteSpace(name) ? "" : $"{name}_")}ChangedEvent_Runtime_{typeof(E1)}";
                }

                return _changed as E;
            }
            if (typeof(E) == typeof(E2))
            {
                if (_changedWithHistory == null)
                {
                    _changedWithHistory = ScriptableObject.CreateInstance<E2>();
                    _changedWithHistory.name = $"{(String.IsNullOrWhiteSpace(name) ? "" : $"{name}_")}ChangedWithHistoryEvent_Runtime_{typeof(E2)}";
                }

                return _changedWithHistory as E;
            }

            throw new NotSupportedException($"Event type {typeof(E)} not supported! Use {typeof(E1)} or {typeof(E2)}.");
        }
    }
}
