using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Events.
    /// </summary>
    /// <typeparam name="T">The type for this Event.</typeparam>
    [EditorIcon("atom-icon-cherry")]
    public class AtomEvent<T> : AtomEventBase
    {
        /// <summary>
        /// Value used when raising events at runtime with the inspector.
        /// </summary>
        public T InspectorRaiseValue => _inspectorRaiseValue;

        /// <summary>
        /// Retrieve Replay Buffer as a List. This call will allocate memory so use sparsely.
        /// </summary>
        public List<T> ReplayBuffer => _replayBuffer.ToList();

        /// <summary>
        /// How many items to store in the replay buffer.
        /// </summary>
        public int ReplayBufferSize { get => _replayBufferSize; set => _replayBufferSize = value; }

        /// <summary>
        /// <see cref="MulticastDelegate"/> to invoke when the event is raised.
        /// </summary>
        protected event Action<T> _onEvent;

        /// <summary>
        /// The event replays the specified number of old values to new subscribers. Works like a ReplaySubject in Rx.
        /// </summary>
        [SerializeField]
        [Range(0, 10)]
        [Tooltip("The number of old values (between 0-10) being replayed when someone subscribes to this Event.")]
        private int _replayBufferSize = 1;

        /// <summary>
        /// Stores the replay buffer.
        /// </summary>
        private readonly Queue<T> _replayBuffer = new Queue<T>();

        /// <summary>
        /// This function is called when the scriptable object goes out of scope.
        /// </summary>
        private void OnDisable()
        {
            _onEvent = null;
        }

        /// <summary>
        /// Used when raising values from the inspector for debugging purposes.
        /// </summary>
        [SerializeField]
        [Tooltip("Value that will be used when using the Raise button in the editor inspector.")]
        private T _inspectorRaiseValue = default(T);

        /// <summary>
        /// Raise the Event.
        /// </summary>
        /// <param name="item">The value associated with the Event.</param>
        public void Raise(T item)
        {
#if !UNITY_ATOMS_GENERATE_DOCS && UNITY_EDITOR
            StackTraces.AddStackTrace(GetInstanceID(), StackTraceEntry.Create(item));
#endif
            base.Raise();
            _onEvent?.Invoke(item);
            AddToReplayBuffer(item);
        }

        /// <summary>
        /// Used in editor scripts since Raise is ambiguous when using reflection to get method.
        /// </summary>
        public void RaiseEditor(T item) => Raise(item);

        /// <summary>
        /// Register handler to be called when the Event triggers.
        /// </summary>
        /// <param name="action">The handler.</param>
        public void Register(Action<T> action)
        {
            _onEvent += action;
            ReplayBufferToSubscriber(action);
        }

        /// <summary>
        /// Unregister handler that was registered using the <see cref="Register"/> method.
        /// </summary>
        /// <param name="action">The handler.</param>
        public void Unregister(Action<T> action)
        {
            _onEvent -= action;
        }

        /// <summary>
        /// Unregister all handlers that were registered using the <see cref="Register"/> method.
        /// </summary>
        public override void UnregisterAll()
        {
            base.UnregisterAll();
            _onEvent = null;
        }

        /// <summary>
        /// Register a Listener that in turn trigger all its associated handlers when the Event is invoked.
        /// </summary>
        /// <param name="listener">The Listener to register.</param>
        public void RegisterListener(IAtomListener<T> listener, bool replayEventsBuffer = true)
        {
            _onEvent += listener.OnEventRaised;
            if (replayEventsBuffer)
                ReplayBufferToSubscriber(listener.OnEventRaised);
        }

        /// <summary>
        /// Unregister a listener that was registered using the <see cref="RegisterListener"/> method.
        /// </summary>
        /// <param name="listener">The Listener to unregister.</param>
        public void UnregisterListener(IAtomListener<T> listener)
        {
            _onEvent -= listener.OnEventRaised;
        }

        /// <summary>
        /// Turn the Event into an <see cref="IObservable{T}"/>. Makes Events compatible with for example UniRx.
        /// </summary>
        /// <returns>The Event as an <see cref="IObservable{T}"/>.</returns>
        public IObservable<T> Observe() => new ObservableEvent<T>(Register, Unregister);

        /// <summary>
        /// Adds <paramref name="item"/> to the replay buffer.
        /// </summary>
        /// <param name="item">The item to add.</param>
        protected void AddToReplayBuffer(T item)
        {
            if (_replayBufferSize <= 0) return;

            while (_replayBuffer.Count >= _replayBufferSize)
                _replayBuffer.Dequeue();

            _replayBuffer.Enqueue(item);
        }

        /// <summary>
        /// Invokes the <paramref name="action"/> on every element in the replayBuffer.
        /// </summary>
        /// <param name="action">The action to call on each item in the replay buffer.</param>
        private void ReplayBufferToSubscriber(Action<T> action)
        {
            if (_replayBufferSize <= 0 || _replayBuffer.Count <= 0) return;

            foreach (T item in _replayBuffer)
                action(item);
        }
    }
}
