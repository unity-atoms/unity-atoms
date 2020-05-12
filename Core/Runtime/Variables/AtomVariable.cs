using System;
using System.Collections.Generic;
using UnityEngine;

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
    public abstract class AtomVariable<T, P, E1, E2, F> : AtomBaseVariable<T>, IGetEvent, ISetEvent
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
        public E1 Changed;

        /// <summary>
        /// Changed with history Event triggered when the Variable value gets changed.
        /// </summary>
        public E2 ChangedWithHistory;

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
            _oldValue = InitialValue;
            _value = InitialValue;

            if (Changed != null && _triggerChangedOnOnEnable)
            {
                Changed.Raise(Value);
            }
            if (ChangedWithHistory != null && _triggerChangedWithHistoryOnOnEnable)
            {
                var pair = default(P);
                pair.Item1 = _value;
                pair.Item2 = _oldValue;
                ChangedWithHistory.Raise(pair);
            }
        }

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
            if (Changed is E evt1)
                return evt1;
            if (ChangedWithHistory is E evt2)
                return evt2;

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
    }
}
