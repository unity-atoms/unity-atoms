using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public abstract class GameEvent<T> : ScriptableObject, IGameEvent<T>
    {
        private readonly List<IGameEventListener<T>> eventListeners = new List<IGameEventListener<T>>();

        public void Raise(T item)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(item);
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }

    [Serializable]
    public abstract class GameEvent<T1, T2> : ScriptableObject, IGameEvent<T1, T2>
    {
        private readonly List<IGameEventListener<T1, T2>> eventListeners = new List<IGameEventListener<T1, T2>>();

        public void Raise(T1 item1, T2 item2)
        {
            for (int i = eventListeners.Count - 1; i >= 0; i--)
                eventListeners[i].OnEventRaised(item1, item2);
        }

        public void RegisterListener(IGameEventListener<T1, T2> listener)
        {
            if (!eventListeners.Contains(listener))
                eventListeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T1, T2> listener)
        {
            if (eventListeners.Contains(listener))
                eventListeners.Remove(listener);
        }
    }
}