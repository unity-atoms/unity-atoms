using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    public abstract class GameEventListener<T, GA, E, UER> : MonoBehaviour, IGameEventListener<T> where GA : GameAction<T> where E : GameEvent<T> where UER : UnityEvent<T>
    {
        [SerializeField]
        private E Event;

        public E GameEvent { get { return Event; } set { Event = value; } }

        [SerializeField]
        private UER UnityEventResponse;

        [SerializeField]
        private List<GA> GameActionResponses = new List<GA>();

        private void OnEnable()
        {
            if (Event == null) return;
            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T item)
        {
            if (UnityEventResponse != null) { UnityEventResponse.Invoke(item); }
            for (int i = 0; GameActionResponses != null && i < GameActionResponses.Count; ++i)
            {
                GameActionResponses[i].Do(item);
            }
        }
    }

    public abstract class GameEventListener<T1, T2, GA, E, UER> : MonoBehaviour, IGameEventListener<T1, T2> where GA : GameAction<T1, T2> where E : GameEvent<T1, T2> where UER : UnityEvent<T1, T2>
    {
        [SerializeField]
        private E Event;

        public E GameEvent { get { return Event; } set { Event = value; } }

        [SerializeField]
        private UER UnityEventResponse;

        [SerializeField]
        private List<GA> GameActionResponses = new List<GA>();

        private void OnEnable()
        {
            if (Event == null) return;
            GameEvent.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (Event == null) return;
            GameEvent.UnregisterListener(this);
        }

        public void OnEventRaised(T1 first, T2 second)
        {
            if (UnityEventResponse != null) { UnityEventResponse.Invoke(first, second); }
            for (int i = 0; GameActionResponses != null && i < GameActionResponses.Count; ++i)
            {
                GameActionResponses[i].Do(first, second);
            }
        }
    }
}