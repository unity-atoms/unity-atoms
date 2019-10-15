using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Listeners. Inherits from `MonoBehaviour` and `IAtomListener&lt;T&gt;`
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="GA"></typeparam>
    /// <typeparam name="E"></typeparam>
    /// <typeparam name="UER"></typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomListener<T, GA, E, UER> : MonoBehaviour, IAtomListener<T>
        where GA : AtomAction<T>
        where E : AtomEvent<T> where UER : UnityEvent<T>
    {
        [FormerlySerializedAs("Event")]
        [SerializeField]
        private E _event = null;

        public E Event { get { return _event; } set { _event = value; } }

        [FormerlySerializedAs("UnityEventResponse")]
        [SerializeField]
        private UER _unityEventResponse = null;

        [FormerlySerializedAs("GameActionResponses")]
        [SerializeField]
        private List<GA> _actionResponses = new List<GA>();

        private void OnEnable()
        {
            if (Event == null) return;
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (Event == null) return;
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(T item)
        {
            if (_unityEventResponse != null) { _unityEventResponse.Invoke(item); }
            for (int i = 0; _actionResponses != null && i < _actionResponses.Count; ++i)
            {
                _actionResponses[i].Do(item);
            }
        }
    }

    [EditorIcon("atom-icon-orange")]
    public abstract class AtomListener<T1, T2, GA, E, UER> : MonoBehaviour, IAtomListener<T1, T2>
        where GA : AtomAction<T1, T2>
        where E : AtomEvent<T1, T2>
        where UER : UnityEvent<T1, T2>
    {
        [FormerlySerializedAs("Event")]
        [SerializeField]
        private E _event;

        public E Event { get { return _event; } set { _event = value; } }

        [FormerlySerializedAs("UnityEventResponse")]
        [SerializeField]
        private UER _unityEventResponse = null;

        [FormerlySerializedAs("GameActionResponses")]
        [SerializeField]
        private List<GA> _actionResponses = new List<GA>();

        private void OnEnable()
        {
            if (_event == null) return;
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (_event == null) return;
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(T1 first, T2 second)
        {
            if (_unityEventResponse != null) { _unityEventResponse.Invoke(first, second); }
            for (int i = 0; _actionResponses != null && i < _actionResponses.Count; ++i)
            {
                _actionResponses[i].Do(first, second);
            }
        }
    }
}
