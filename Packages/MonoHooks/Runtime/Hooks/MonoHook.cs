using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Generic base class for all Mono Hooks.
    /// </summary>
    /// <typeparam name="T">Event value type</typeparam>
    [EditorIcon("atom-icon-delicate")]
    public abstract class MonoHook<T> : MonoBehaviour
    {
        /// <summary>
        /// The Event
        /// </summary>
        public AtomEvent<T> Event { get => _eventReference.Event; set => _eventReference.Event = value; }

        [SerializeField]
        private AtomEventReference<T> _eventReference = default(AtomEventReference<T>);

        /// <summary>
        /// Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.
        /// </summary>
        [SerializeField]
        protected AtomFunction<GameObject, GameObject> _selectGameObjectReference = default(AtomFunction<GameObject, GameObject>);

        protected void OnHook(T value)
        {
            if (Event != null)
            {
                Event.Raise(value);
            }
            RaiseWithGameObject(value, _selectGameObjectReference != null ? _selectGameObjectReference.Call(gameObject) : gameObject);
        }

        protected abstract void RaiseWithGameObject(T value, GameObject gameObject);
    }
}
