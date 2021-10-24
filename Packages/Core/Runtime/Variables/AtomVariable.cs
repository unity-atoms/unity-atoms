using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Variables. Inherits from `AtomBaseVariable&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The Variable value type.</typeparam>
    [EditorIcon("atom-icon-lush")]
    public abstract class AtomVariable<T> : AtomBaseVariable<T>, IGetEvent, ISetEvent
    {

        #region Properties
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
        public AtomEvent<T> Changed
        {
            get => _changed;
            set => _changed = value;
        }

        /// <summary>
        /// Changed with history Event triggered when the Variable value gets changed.
        /// </summary>
        public AtomEvent<Pair<T>> ChangedWithHistory
        {
            get => _changedWithHistory;
            set => _changedWithHistory = value;
        }
        #endregion Properties

        #region Fields
        /// <summary>
        /// Manage asset's lifetime
        /// </summary>
        [SerializeField]
        private Scope _scope = Scope.Global;

        [SerializeField]
        private AtomEvent<T> _changed;

        [SerializeField]
        private AtomEvent<Pair<T>> _changedWithHistory;

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
        public List<AtomFunction<T, T>> PreChangeTransformers
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
        private List<AtomFunction<T, T>> _preChangeTransformers = new List<AtomFunction<T, T>>();

        protected abstract bool ValueEquals(T other);
        #endregion Fields

        #region MonoBehaviour
        private void OnValidate()
        {
            InitialValue = RunPreChangeTransformers(InitialValue);
            _value = RunPreChangeTransformers(_value);
        }

        private void OnEnable()
        {
            _oldValue = InitialValue;
            _value = InitialValue;

            ManageLifetime(_scope);

            if (Changed != null && _triggerChangedOnOnEnable)
            {
                Changed.Raise(Value);
            }
            if (ChangedWithHistory != null && _triggerChangedWithHistoryOnOnEnable)
            {
                var pair = default(Pair<T>);
                pair.Item1 = _value;
                pair.Item2 = _oldValue;
                ChangedWithHistory.Raise(pair);
            }
        }

        private void OnDisable()
        {
            if (_scope == Scope.Scene)
            {
                SceneManager.activeSceneChanged -= OnActiveSceneChanged;
            }
        }
        #endregion MonoBehaviour

        protected override void OnActiveSceneChanged(Scene scene1, Scene scene2)
        {
            ResetValue();
        }

        /// <summary>
        /// Reset the Variable's Value to its `_initialValue`.
        /// </summary>
        /// <param name="shouldTriggerEvents">Set to `true` if Events should be triggered on reset, otherwise `false`.</param>
        public override void ResetValue(bool shouldTriggerEvents = false)
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
                    var pair = default(Pair<T>);
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
        public bool SetValue(AtomVariable<T> variable)
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
        public IObservable<Pair<T>> ObserveChangeWithHistory()
        {
            if (ChangedWithHistory == null)
            {
                throw new Exception("You must assign a ChangedWithHistory event in order to observe variable changes.");
            }

            return new ObservableEvent<Pair<T>>(ChangedWithHistory.Register, ChangedWithHistory.Unregister);
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
            if (typeof(E).IsSameOrSubclass(typeof(AtomEvent<T>)))
            {
                return (Changed as E);
            }
            if (typeof(E).IsSameOrSubclass(typeof(AtomEvent<Pair<T>>)))
            {
                return (ChangedWithHistory as E);
            }

            throw new NotSupportedException($"Event type {typeof(E)} not supported! Use {typeof(AtomEvent<T>)} or {typeof(AtomEvent<Pair<T>>)}.");
        }

        /// <summary>
        /// Set event by type.
        /// </summary>
        /// <param name="e">The new event value.</param>
        /// <typeparam name="E"></typeparam>
        public void SetEvent<E>(E e) where E : AtomEventBase
        {
            if (typeof(E).IsSameOrSubclass(typeof(AtomEvent<T>)))
            {
                Changed = (e as AtomEvent<T>);
                return;
            }
            if (typeof(E).IsSameOrSubclass(typeof(AtomEvent<Pair<T>>)))
            {
                ChangedWithHistory = (e as AtomEvent<Pair<T>>);
                return;
            }

            throw new Exception($"Event type {typeof(E)} not supported! Use {typeof(AtomEvent<T>)} or {typeof(AtomEvent<Pair<T>>)}.");
        }
    }
}
