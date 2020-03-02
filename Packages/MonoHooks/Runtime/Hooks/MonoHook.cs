using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Generic base class for all Mono Hooks.
    /// </summary>
    /// <typeparam name="E">Event of type `AtomEvent&lt;EV&gt;`</typeparam>
    /// <typeparam name="EV">Event value type</typeparam>
    /// <typeparam name="F">Function type `AtomFunction&lt;GameObject, GameObject&gt;`</typeparam>
    [EditorIcon("atom-icon-delicate")]
    public abstract class MonoHook<E, EV, ER, F> : MonoBehaviour
        where E : AtomEvent<EV>
        where ER : IGetEvent, ISetEvent
        where F : AtomFunction<GameObject, GameObject>
    {
        /// <summary>
        /// The Event
        /// </summary>
        public E Event { get => _eventReference.GetEvent<E>(); set => _eventReference.SetEvent<E>(value); }

        [SerializeField]
        private ER _eventReference = default(ER);

        /// <summary>
        /// Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.
        /// </summary>
        [SerializeField]
        protected F _selectGameObjectReference = default(F);

        protected void OnHook(EV value)
        {
            if (Event != null)
            {
                Event.Raise(value);
            }
            RaiseWithGameObject(value, _selectGameObjectReference != null ? _selectGameObjectReference.Call(gameObject) : gameObject);
        }

        protected abstract void RaiseWithGameObject(EV value, GameObject gameObject);
    }
}
