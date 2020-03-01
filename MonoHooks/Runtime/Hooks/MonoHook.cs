using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Generic base class for all Mono Hooks.
    /// </summary>
    /// <typeparam name="E1">Event of type `AtomEvent&lt;EV&gt;`</typeparam>
    /// <typeparam name="E2">Event of type `AtomEvent&lt;EV, GameObject&gt;`</typeparam>
    /// <typeparam name="EV">Event value type</typeparam>
    /// <typeparam name="EV">Event value type with GameObject</typeparam>
    /// <typeparam name="F">Function type `AtomFunction&lt;GameObject, GameObject&gt;`</typeparam>
    [EditorIcon("atom-icon-delicate")]
    public abstract class MonoHook<E1, E2, EV, EVG, F> : MonoBehaviour
        where E1 : AtomEvent<EV>
        where E2 : AtomEvent<EVG>
        where F : AtomFunction<GameObject, GameObject>
    {
        /// <summary>
        /// The Event
        /// </summary>
        public E1 Event { get => _event; set => _event = value; }


        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public E2 EventWithGameObjectReference { get => _eventWithGameObjectReference; set => _eventWithGameObjectReference = value; }



        [SerializeField]
        private E1 _event;

        [SerializeField]
        private E2 _eventWithGameObjectReference;

        /// <summary>
        /// Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.
        /// </summary>
        [SerializeField]
        protected F _selectGameObjectReference;

        protected void OnHook(EV value)
        {
            if (Event != null)
            {
                Event.Raise(value);
            }
            if (EventWithGameObjectReference != null)
            {

                RaiseWithGameObject(value, _selectGameObjectReference != null ? _selectGameObjectReference.Call(gameObject) : gameObject);
            }
        }

        protected abstract void RaiseWithGameObject(EV value, GameObject gameObject);
    }
}
