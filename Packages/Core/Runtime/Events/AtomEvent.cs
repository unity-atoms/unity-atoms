using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Events. Inherits from `AtomEventBase`.
    /// </summary>
    /// <typeparam name="T">The type for this Event.</typeparam>
    [EditorIcon("atom-icon-cherry")]
    public abstract class AtomEvent<T> : AtomEventBase
    {
        [SerializeField]
        private event Action<T> _onEvent;

        /// <summary>
        /// The event replays the specified number of old values to new subscribers. Works like a ReplaySubject in Rx. 
        /// </summary>
        [SerializeField]
        [Range(0, 10)]
        [Tooltip("The number of old values (between 0-10) being replayed when someone subscribes to this Event.")]
        private int _replayBufferSize = 1;

        private Queue<T> _replayBuffer = new Queue<T>();

        private void OnDisable()
        {
            // Clear all delegates when exiting play mode
            if (_onEvent != null)
            {
                var invocationList = _onEvent.GetInvocationList();
                foreach (var d in invocationList)
                {
                    _onEvent -= (Action<T>)d;
                }
            }
        }

        /// <summary>
        /// Used when raising values from the inspector for debugging purposes.
        /// </summary>
        [SerializeField]
        [Tooltip("Value that will be used when using the Raise button in the editor inspector.")]
        private T _raiseValue;

        /// <summary>
        /// Raise the Event.
        /// </summary>
        /// <param name="item">The value associated with the Event.</param>
        public void Raise(T item)
        {
            base.RaiseNoValue();
            _onEvent?.Invoke(item);
            AddToReplayBuffer(item);
        }

        /// <summary>
        /// Register handler to be called when the Event triggers.
        /// </summary>
        /// <param name="action">The handler.</param>
        public void Register(Action<T> action)
        {
            _onEvent += action;
            ReplayBuffer(action);
        }

        /// <summary>
        /// Unregister handler that was registered using the `Register` method.
        /// </summary>
        /// <param name="action">The handler.</param>
        public void Unregister(Action<T> action)
        {
            _onEvent -= action;
        }

        /// <summary>
        /// Register a Listener that in turn trigger all its associated handlers when the Event triggers.
        /// </summary>
        /// <param name="listener">The Listener to register.</param>
        public void RegisterListener(IAtomListener<T> listener)
        {
            _onEvent += listener.OnEventRaised;
            ReplayBuffer(listener.OnEventRaised);
        }

        /// <summary>
        /// Unregister a listener that was registered using the `RegisterListener` method.
        /// </summary>
        /// <param name="listener">The Listener to unregister.</param>
        public void UnregisterListener(IAtomListener<T> listener)
        {
            _onEvent -= listener.OnEventRaised;
        }

        #region Observable
        /// <summary>
        /// Turn the Event into an `IObservable&lt;T&gt;`. Makes Events compatible with for example UniRx.
        /// </summary>
        /// <returns>The Event as an `IObservable&lt;T&gt;`.</returns>
        public IObservable<T> Observe()
        {
            return new ObservableEvent<T>(Register, Unregister);
        }
        #endregion // Observable

        private void AddToReplayBuffer(T item)
        {
            if (_replayBufferSize > 0)
            {
                while (_replayBuffer.Count >= _replayBufferSize) { _replayBuffer.Dequeue(); }
                _replayBuffer.Enqueue(item);
            }
        }

        private void ReplayBuffer(Action<T> action)
        {
            if (_replayBufferSize > 0 && _replayBuffer.Count > 0)
            {
                var enumerator = _replayBuffer.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        action(enumerator.Current);
                    }
                }
                finally
                {
                    enumerator.Dispose();
                }
            }
        }
    }

    /// <summary>
    /// Generic base class for Events. Inherits from `AtomEventBase`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Event.</typeparam>
    /// <typeparam name="T2">The second type for this Event.</typeparam>
    [EditorIcon("atom-icon-cherry")]
    public abstract class AtomEvent<T1, T2> : AtomEventBase
    {

        [SerializeField]
        private event Action<T1, T2> _onEvent;

        /// <summary>
        /// The event replays the specified number of old values to new subscribers. Works like a ReplaySubject in Rx. 
        /// </summary>
        [SerializeField]
        [Range(0, 10)]
        [Tooltip("The number of old values (between 0-10) being replayed when someone subscribes to this Event.")]
        private int _replayBufferSize = 1;

        private Queue<(T1, T2)> _replayBuffer = new Queue<(T1, T2)>();

        /// <summary>
        /// Used when raising values from the inspector for debugging purposes.
        /// </summary>
        [SerializeField]
        [Tooltip("First value that will be used when using the Raise button in the editor inspector.")]
        private T1 _raiseValue1;

        /// <summary>
        /// Used when raising values from the inspector for debugging purposes.
        /// </summary>
        [SerializeField]
        [Tooltip("Second value that will be used when using the Raise button in the editor inspector.")]
        private T2 _raiseValue2;

        private void OnDisable()
        {
            // Clear all delegates when exiting play mode
            if (_onEvent != null)
            {
                var invocationList = _onEvent.GetInvocationList();
                foreach (var d in invocationList)
                {

                    _onEvent -= (Action<T1, T2>)d;
                }
            }
        }

        /// <summary>
        /// Raise the Event.
        /// </summary>
        /// <param name="item1">The first value associated with the Event.</param>
        /// <param name="item2">The second value associated with the Event.</param>
        public void Raise(T1 item1, T2 item2)
        {
            base.RaiseNoValue();
            _onEvent?.Invoke(item1, item2);
            AddToReplayBuffer(item1, item2);
        }

        /// <summary>
        /// Register handler to be called when the Event triggers.
        /// </summary>
        /// <param name="action">The handler.</param>
        public void Register(Action<T1, T2> action)
        {
            _onEvent += action;
            ReplayBuffer(action);
        }

        /// <summary>
        /// Unregister handler that was registered using the `Register` method.
        /// </summary>
        /// <param name="action">The handler.</param>
        public void Unregister(Action<T1, T2> action)
        {
            _onEvent -= action;
        }

        /// <summary>
        /// Register a Listener that in turn trigger all its associated handlers when the Event triggers.
        /// </summary>
        /// <param name="listener">The Listener to register.</param>
        public void RegisterListener(IAtomListener<T1, T2> listener)
        {
            _onEvent += listener.OnEventRaised;
            ReplayBuffer(listener.OnEventRaised);
        }

        /// <summary>
        /// Unregister a listener that was registered using the `RegisterListener` method.
        /// </summary>
        /// <param name="listener">The Listener to unregister.</param>
        public void UnregisterListener(IAtomListener<T1, T2> listener)
        {
            _onEvent -= listener.OnEventRaised;
        }

        #region Observable

        /// <summary>
        /// Turn the Event into an `IObservable&lt;M&gt;`. Makes Events compatible with for example UniRx.
        /// </summary>
        /// <param name="resultSelector">Takes `T1` and `T2` and returns a new type of type `M`.abstract Most of the time this is going to be combination of T1 and T2, eg. `ValueTuple&lt;T1, T2&gt;`</param>
        /// <typeparam name="M">The result selector type.</typeparam>
        /// <returns>The Event as an `IObservable&lt;M&gt;`.</returns>
        public IObservable<M> Observe<M>(Func<T1, T2, M> resultSelector)
        {
            return new ObservableEvent<T1, T2, M>(Register, Unregister, resultSelector);
        }
        #endregion // Observable

        private void AddToReplayBuffer(T1 item1, T2 item2)
        {
            if (_replayBufferSize > 0)
            {
                while (_replayBuffer.Count >= _replayBufferSize) { _replayBuffer.Dequeue(); }
                _replayBuffer.Enqueue((item1, item2));
            }
        }

        private void ReplayBuffer(Action<T1, T2> action)
        {
            if (_replayBufferSize > 0 && _replayBuffer.Count > 0)
            {
                var enumerator = _replayBuffer.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        action(enumerator.Current.Item1, enumerator.Current.Item2);
                    }
                }
                finally
                {
                    enumerator.Dispose();
                }
            }
        }
    }
}
