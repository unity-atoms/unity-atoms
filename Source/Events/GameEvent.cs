using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class GameEvent<T> : ScriptableObject, ISerializationCallbackReceiver
    {
        public event Action<T> OnEvent;

        public void Raise(T item)
        {
            OnEvent?.Invoke(item);
        }

        public void Register(Action<T> del)
        {
            OnEvent += del;
        }

        public void Unregister(Action<T> del)
        {
            OnEvent -= del;
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            OnEvent += listener.OnEventRaised;
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            OnEvent -= listener.OnEventRaised;
        }

        #region Observable
        public IObservable<T> Observe()
        {
            return new ObservableEvent<T>(Register, Unregister);
        }
        #endregion // Observable

        public void OnBeforeSerialize() { }

        public void OnAfterDeserialize()
        {
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

    public abstract class GameEvent<T1, T2> : ScriptableObject, ISerializationCallbackReceiver
    {
        public event Action<T1, T2> OnEvent;

        public void Raise(T1 item1, T2 item2)
        {
            OnEvent?.Invoke(item1, item2);
        }

        public void Register(Action<T1, T2> del)
        {
            OnEvent += del;
        }

        public void Unregister(Action<T1, T2> del)
        {
            OnEvent -= del;
        }

        public void RegisterListener(IGameEventListener<T1, T2> listener)
        {
            OnEvent += listener.OnEventRaised;
        }

        public void UnregisterListener(IGameEventListener<T1, T2> listener)
        {
            OnEvent -= listener.OnEventRaised;
        }

        #region Observable
        public IObservable<M> Observe<M>(Func<T1, T2, M> createCombinedModel)
        {
            return new ObservableEvent<T1, T2, M>(Register, Unregister, createCombinedModel);
        }
        #endregion // Observable

        public void OnBeforeSerialize() { }

        public void OnAfterDeserialize()
        {
            // Clear all delegates when exiting play mode
            if (OnEvent != null)
                foreach (var d in OnEvent.GetInvocationList())
                {
                    OnEvent -= (Action<T1, T2>)d;
                }
        }
    }
}
