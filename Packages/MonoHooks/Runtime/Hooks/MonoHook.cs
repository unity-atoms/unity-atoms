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
    /// <typeparam name="F">Function type `AtomFunction&lt;GameObject, GameObject&gt;`</typeparam>
    [EditorIcon("atom-icon-delicate")]
    public abstract class MonoHook<E1, E2, EV, F> : MonoBehaviour
        where E1 : AtomEvent<EV> where E2 : AtomEvent<EV, GameObject>
        where F : AtomFunction<GameObject, GameObject>
    {
        /// <summary>
        /// The Event
        /// </summary>
        public E1 Event;

        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        [FormerlySerializedAs("EventWithGORef")]
        public E2 EventWithGameObjectReference;

        /// <summary>
        /// Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.
        /// </summary>
        [FormerlySerializedAs("SelectGORef")]
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
                EventWithGameObjectReference.Raise(value, _selectGameObjectReference != null ? _selectGameObjectReference.Call(gameObject) : gameObject);
            }
        }
    }
}
