using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class GameEvent<T> : ScriptableObject
    {
        public event Action<T> OnEvent;

        public void Raise(T item)
        {
            OnEvent?.Invoke(item);
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            OnEvent += listener.OnEventRaised;
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            OnEvent -= listener.OnEventRaised;
        }
    }

    public abstract class GameEvent<T1, T2> : ScriptableObject
    {
        public event Action<T1, T2> OnEvent;

        public void Raise(T1 item1, T2 item2)
        {
            OnEvent?.Invoke(item1, item2);
        }

        public void RegisterListener(IGameEventListener<T1, T2> listener)
        {
            OnEvent += listener.OnEventRaised;
        }

        public void UnregisterListener(IGameEventListener<T1, T2> listener)
        {
            OnEvent -= listener.OnEventRaised;
        }
    }
}
