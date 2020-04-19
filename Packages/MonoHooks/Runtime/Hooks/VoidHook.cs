using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `AtomEventBase`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class VoidHook : MonoBehaviour
    {
        /// <summary>
        /// The Event
        /// </summary>
        [SerializeField]
        protected VoidEvent _event;

        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        [SerializeField]
        protected GameObjectEvent _eventWithGameObjectReference;

        /// <summary>
        /// Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.
        /// </summary>
        [SerializeField]
        protected GameObjectGameObjectFunction _selectGameObjectReference;

        protected void OnHook()
        {
            if (_event != null)
            {
                _event.Raise();
            }
            if (_eventWithGameObjectReference != null)
            {
                _eventWithGameObjectReference.Raise(_selectGameObjectReference != null ? _selectGameObjectReference.Call(gameObject) : gameObject);
            }
        }
    }
}
