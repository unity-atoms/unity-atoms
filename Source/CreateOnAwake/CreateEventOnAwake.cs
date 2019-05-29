using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class CreateEventOnAwake<T, E1, E2, L1, L2, GA1, GA2, UER1, UER2, MH> : MonoBehaviour
        where E1 : GameEvent<T> where E2 : GameEvent<T, GameObject>
        where L1 : GameEventListener<T, GA1, E1, UER1> where L2 : GameEventListener<T, GameObject, GA2, E2, UER2>
        where GA1 : GameAction<T> where GA2 : GameAction<T, GameObject>
        where UER1 : UnityEvent<T> where UER2 : UnityEvent<T, GameObject>
        where MH : MonoHook<E1, E2, T, GameObjectGameObjectFunction>
    {
        [FormerlySerializedAs("CreateEvent")]
        [SerializeField]
        private bool _createEvent = true;

        [FormerlySerializedAs("CreateEventWithGameObject")]
        [SerializeField]
        private bool _createEventWithGameObject = true;

        [FormerlySerializedAs("MonoHooks")]
        [SerializeField]
        private List<MH> _monoHooks = null;

        [FormerlySerializedAs("Listener")]
        [SerializeField]
        private L1 _listener = null;

        [FormerlySerializedAs("ListenerWithGameObject")]
        [SerializeField]
        private L2 _listenerWithGameObject = null;

        private void Awake()
        {
            var e1 = _createEvent ? ScriptableObject.CreateInstance<E1>() : null;
            var e2 = _createEventWithGameObject ? ScriptableObject.CreateInstance<E2>() : null;

            if (e1 != null)
            {
                for (int i = 0; _monoHooks != null && i < _monoHooks.Count; ++i)
                {
                    _monoHooks[i].Event = e1;
                }
                if (_listener != null)
                {
                    _listener.GameEvent = e1;
                    e1.RegisterListener(_listener);
                }
            }
            if (e2 != null)
            {
                for (int i = 0; _monoHooks != null && i < _monoHooks.Count; ++i)
                {
                    _monoHooks[i].EventWithGameObjectReference = e2;
                }
                if (_listenerWithGameObject != null)
                {
                    _listenerWithGameObject.GameEvent = e2;
                    e2.RegisterListener(_listenerWithGameObject);
                }
            }
        }
    }
}
