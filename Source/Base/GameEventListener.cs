using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class GameEventListener<T, GA, E, UER> : MonoBehaviour, IGameEventListener<T>
        where GA : GameAction<T>
        where E : GameEvent<T> where UER : UnityEvent<T>
    {
        [FormerlySerializedAs("Event")]
        [SerializeField]
        private E _event;

        public E GameEvent { get { return _event; } set { _event = value; } }

        [FormerlySerializedAs("UnityEventResponse")]
        [SerializeField]
        private UER _unityEventResponse;

        [FormerlySerializedAs("GameActionResponses")]
        [SerializeField]
        private List<GA> _gameActionResponses = new List<GA>();

        private void OnEnable()
        {
            if (_event == null) return;
            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T item)
        {
            if (_unityEventResponse != null) { _unityEventResponse.Invoke(item); }
            for (int i = 0; _gameActionResponses != null && i < _gameActionResponses.Count; ++i)
            {
                _gameActionResponses[i].Do(item);
            }
        }
    }

    public abstract class GameEventListener<T1, T2, GA, E, UER> : MonoBehaviour, IGameEventListener<T1, T2>
        where GA : GameAction<T1, T2>
        where E : GameEvent<T1, T2>
        where UER : UnityEvent<T1, T2>
    {
        [FormerlySerializedAs("Event")]
        [SerializeField]
        private E _event;

        public E GameEvent { get { return _event; } set { _event = value; } }

        [FormerlySerializedAs("UnityEventResponse")]
        [SerializeField]
        private UER _unityEventResponse;

        [FormerlySerializedAs("GameActionResponses")]
        [SerializeField]
        private List<GA> _gameActionResponses = new List<GA>();

        private void OnEnable()
        {
            if (_event == null) return;
            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (_event == null) return;
            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T1 first, T2 second)
        {
            if (_unityEventResponse != null) { _unityEventResponse.Invoke(first, second); }
            for (int i = 0; _gameActionResponses != null && i < _gameActionResponses.Count; ++i)
            {
                _gameActionResponses[i].Do(first, second);
            }
        }
    }
}
