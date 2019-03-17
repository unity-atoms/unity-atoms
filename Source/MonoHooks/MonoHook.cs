using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    public class MonoHook<E1, E2, EV, SF> : MonoBehaviour
        where E1 : GameEvent<EV> where E2 : GameEvent<EV, GameObject>
        where SF : GameFunction<GameObject, GameObject>
    {
        public E1 Event;

        public E2 EventWithGORef;

        [SerializeField]
        protected SF SelectGORef;

        protected void OnHook(EV value)
        {
            if (Event != null)
            {
                Event.Raise(value);
            }
            if (EventWithGORef != null)
            {
                EventWithGORef.Raise(value, SelectGORef != null ? SelectGORef.Call(gameObject) : gameObject);
            }
        }
    }
}