using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class MonoHook<E1, E2, EV, SF> : MonoBehaviour
        where E1 : GameEvent<EV> where E2 : GameEvent<EV, GameObject>
        where SF : GameFunction<GameObject, GameObject>
    {
        public E1 Event;

        [FormerlySerializedAs("EventWithGORef")]
        public E2 EventWithGameObjectReference;

        [FormerlySerializedAs("SelectGORef")]
        [SerializeField]
        protected SF _selectGameObjectReference;

        protected void OnHook(EV value)
        {
            if (Event != null)
            {
                Event.Raise(value);
            }
            if (EventWithGameObjectReference != null)
            {
                EventWithGameObjectReference.Raise(value, _selectGameObjectReference != null ? _selectGameObjectReference.Call(gameObject) : gameObject);
            }
        }
    }
}
