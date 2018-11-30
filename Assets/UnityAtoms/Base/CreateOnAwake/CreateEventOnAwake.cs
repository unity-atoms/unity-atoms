using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    public class CreateEventOnAwake<T, E1, E2, L1, L2, GA1, GA2, UER1, UER2, MH> : MonoBehaviour
        where E1 : GameEvent<T> where E2 : GameEvent<T, GameObject>
        where L1 : GameEventListener<T, GA1, E1, UER1> where L2 : GameEventListener<T, GameObject, GA2, E2, UER2>
        where GA1 : GameAction<T> where GA2 : GameAction<T, GameObject>
        where UER1 : UnityEvent<T> where UER2 : UnityEvent<T, GameObject>
        where MH : MonoHook<E1, E2, T, GameObjectGameObjectFunction>
    {
        public bool CreateEvent = true;
        public bool CreateEventWithGameObject = false;

        public List<MH> MonoHooks;
        public L1 Listener;
        public L2 ListenerWithGameObject;

        void Awake()
        {
            var e1 = CreateEvent ? ScriptableObject.CreateInstance<E1>() : null;
            var e2 = CreateEventWithGameObject ? ScriptableObject.CreateInstance<E2>() : null;

            if (e1 != null)
            {
                for (int i = 0; MonoHooks != null && i < MonoHooks.Count; ++i)
                {
                    MonoHooks[i].Event = e1;
                }
                if (Listener != null)
                {
                    Listener.GameEvent = e1;
                    e1.RegisterListener(Listener);
                }
            }
            if (e2 != null)
            {
                for (int i = 0; MonoHooks != null && i < MonoHooks.Count; ++i)
                {
                    MonoHooks[i].EventWithGORef = e2;
                }
                if (ListenerWithGameObject != null)
                {
                    ListenerWithGameObject.GameEvent = e2;
                    e2.RegisterListener(ListenerWithGameObject);
                }
            }
        }
    }
}