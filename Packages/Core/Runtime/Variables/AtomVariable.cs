using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Variables. Inherits from `AtomBaseVariable&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The Variable value type.</typeparam>
    /// <typeparam name="E1">Event of type `AtomEvent&lt;T&gt;`.</typeparam>
    /// <typeparam name="E2">Event of type `AtomEvent&lt;T, T&gt;`.</typeparam>
    [EditorIcon("atom-icon-lush")]
    public abstract class AtomVariable<T, E1, E2> : AtomBaseVariable<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
    {
        /// <summary>
        /// The Variable value as a property.
        /// </summary>
        /// <returns>Get or set the Variable's value.</returns>
        public override T Value { get { return _value; } set { SetValue(value); } }

        /// <summary>
        /// The inital value of the Variable.
        /// </summary>
        [SerializeField]
        private T _initialValue = default(T);

        /// <summary>
        /// The inital Variable value as a property.
        /// </summary>
        /// <returns>Get the Variable's initial value.</returns>
        public T InitialValue { get { return _initialValue; } }

        /// <summary>
        /// The value the Variable had before its value got changed last time.
        /// </summary>
        /// <value>Get the Variable's old value.</value>
        public T OldValue { get { return _oldValue; } }

        [SerializeField]
        private T _oldValue;

        /// <summary>
        /// Changed Event triggered when the Variable value gets changed.
        /// </summary>
        public E1 Changed;

        /// <summary>
        /// Changed with history Event triggered when the Variable value gets changed.
        /// </summary>
        public E2 ChangedWithHistory;

        protected abstract bool AreEqual(T first, T second);

        private void OnEnable()
        {
            _oldValue = _initialValue;
            _value = _initialValue;

            if (Changed == null) return;
            Changed.Raise(Value);
        }

        /// <summary>
        /// Reset the Variable to its `_initalValue`.
        /// </summary>
        /// <param name="shouldTriggerEvents">Set to `true` if Events should be triggered on reset, otherwise `false`.</param>
        public override sealed void Reset(bool shouldTriggerEvents = false)
        {
            if (!shouldTriggerEvents)
            {
                _oldValue = _value;
                _value = _initialValue;
            }
            else
            {
                SetValue(_initialValue);
            }
        }

        /// <summary>
        /// Set the Variable value.
        /// </summary>
        /// <param name="newValue">The new value to set.</param>
        /// <returns>`true` if the value got changed, otherwise `false`.</returns>
        public bool SetValue(T newValue)
        {
            if (!AreEqual(_value, newValue))
            {
                _oldValue = _value;
                _value = newValue;
                if (Changed != null) { Changed.Raise(_value); }
                if (ChangedWithHistory != null) { ChangedWithHistory.Raise(_value, _oldValue); }
                return true;
            }

            return false;
        }

        /// <summary>
        /// Set the Variable value.
        /// </summary>
        /// <param name="variable">The value to set provided from another Variable.</param>
        /// <returns>`true` if the value got changed, otherwise `false`.</returns>
        public bool SetValue(AtomVariable<T, E1, E2> variable)
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
        public IObservable<ValueTuple<T, T>> ObserveChangeWithHistory()
        {
            if (ChangedWithHistory == null)
            {
                throw new Exception("You must assign a ChangedWithHistory event in order to observe variable changes.");
            }

            return new ObservableEvent<T, T, ValueTuple<T, T>>(
                register: ChangedWithHistory.Register,
                unregister: ChangedWithHistory.Unregister,
                createCombinedModel: (n, o) => new ValueTuple<T, T>(n, o)
            );
        }
        #endregion // Observable
    }
}
