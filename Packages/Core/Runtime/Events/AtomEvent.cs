using System;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Events. Inherits from `AtomEventBase`.
    /// </summary>
    /// <typeparam name="T">The type for this Event.</typeparam>
    [EditorIcon("atom-icon-cherry")]
    public abstract class AtomEvent<T> : AtomEventBase
    {
        /// <summary>
        /// Actual event.
        /// </summary>
        public event Action<T> OnEvent;

        /// <summary>
        /// Raise the Event.
        /// </summary>
        /// <param name="item">The value associated with the Event.</param>
        public void Raise(T item)
        {
            base.RaiseNoValue();
            OnEvent?.Invoke(item);
        }

        /// <summary>
        /// Register handler to be called when the Event triggers.
        /// </summary>
        /// <param name="del">The handler.</param>
        public void Register(Action<T> del)
        {
            OnEvent += del;
        }

        /// <summary>
        /// Unregister handler that was registered using the `Register` method.
        /// </summary>
        /// <param name="del">The handler.</param>
        public void Unregister(Action<T> del)
        {
            OnEvent -= del;
        }

        /// <summary>
        /// Register a Listener that in turn trigger all its associated handlers when the Event triggers.
        /// </summary>
        /// <param name="listener">The Listener to register.</param>
        public void RegisterListener(IAtomListener<T> listener)
        {
            OnEvent += listener.OnEventRaised;
        }

        /// <summary>
        /// Unregister a listener that was registered using the `RegisterListener` method.
        /// </summary>
        /// <param name="listener">The Listener to unregister.</param>
        public void UnregisterListener(IAtomListener<T> listener)
        {
            OnEvent -= listener.OnEventRaised;
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

        public override void OnAfterDeserialize()
        {
            base.OnAfterDeserialize();
            // Clear all delegates when exiting play mode
            if (OnEvent != null)
            {
                foreach (var d in OnEvent.GetInvocationList())
                {
                    OnEvent -= (Action<T>)d;
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
        /// <summary>
        /// Actual event.
        /// </summary>
        public event Action<T1, T2> OnEvent;

        /// <summary>
        /// Raise the Event.
        /// </summary>
        /// <param name="item1">The first value associated with the Event.</param>
        /// <param name="item2">The second value associated with the Event.</param>
        public void Raise(T1 item1, T2 item2)
        {
            base.RaiseNoValue();
            OnEvent?.Invoke(item1, item2);
        }

        /// <summary>
        /// Register handler to be called when the Event triggers.
        /// </summary>
        /// <param name="del">The handler.</param>
        public void Register(Action<T1, T2> del)
        {
            OnEvent += del;
        }

        /// <summary>
        /// Unregister handler that was registered using the `Register` method.
        /// </summary>
        /// <param name="del">The handler.</param>
        public void Unregister(Action<T1, T2> del)
        {
            OnEvent -= del;
        }

        /// <summary>
        /// Register a Listener that in turn trigger all its associated handlers when the Event triggers.
        /// </summary>
        /// <param name="listener">The Listener to register.</param>
        public void RegisterListener(IAtomListener<T1, T2> listener)
        {
            OnEvent += listener.OnEventRaised;
        }

        /// <summary>
        /// Unregister a listener that was registered using the `RegisterListener` method.
        /// </summary>
        /// <param name="listener">The Listener to unregister.</param>
        public void UnregisterListener(IAtomListener<T1, T2> listener)
        {
            OnEvent -= listener.OnEventRaised;
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

        public override void OnAfterDeserialize()
        {
            base.OnAfterDeserialize();
            // Clear all delegates when exiting play mode
            if (OnEvent != null)
                foreach (var d in OnEvent.GetInvocationList())
                {
                    OnEvent -= (Action<T1, T2>)d;
                }
        }
    }
}
