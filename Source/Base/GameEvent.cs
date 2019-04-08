using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class GameEvent<T> : ScriptableObject
    {
        private readonly List<IGameEventListener<T>> _eventListeners = new List<IGameEventListener<T>>();

        public void Raise(T item)
        {
            for (int i = _eventListeners.Count - 1; i >= 0; i--)
                _eventListeners[i].OnEventRaised(item);
        }

        public void RegisterListener(IGameEventListener<T> listener)
        {
            if (!_eventListeners.Contains(listener))
                _eventListeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T> listener)
        {
            if (_eventListeners.Contains(listener))
                _eventListeners.Remove(listener);
        }
    }

    public abstract class GameEvent<T1, T2> : ScriptableObject
    {
        private readonly List<IGameEventListener<T1, T2>> _eventListeners = new List<IGameEventListener<T1, T2>>();

        public void Raise(T1 item1, T2 item2)
        {
            for (int i = _eventListeners.Count - 1; i >= 0; i--)
                _eventListeners[i].OnEventRaised(item1, item2);
        }

        public void RegisterListener(IGameEventListener<T1, T2> listener)
        {
            if (!_eventListeners.Contains(listener))
                _eventListeners.Add(listener);
        }

        public void UnregisterListener(IGameEventListener<T1, T2> listener)
        {
            if (_eventListeners.Contains(listener))
                _eventListeners.Remove(listener);
        }
    }
}
