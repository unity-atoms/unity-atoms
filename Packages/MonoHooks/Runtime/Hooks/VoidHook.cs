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
        protected VoidBaseEventReference _eventReference;

        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        [SerializeField]
        protected GameObjectEventReference _eventWithGameObjectReference;

        /// <summary>
        /// Selector function for the Event `EventWithGameObjectReference`. Makes it possible to for example select the parent GameObject and pass that a long to the `EventWithGameObjectReference`.
        /// </summary>
        [SerializeField]
        protected GameObjectGameObjectFunction _selectGameObjectReference;

        protected void OnHook()
        {
            if (_eventReference != null && _eventReference.Event != null)
            {
                _eventReference.Event.Raise();
            }
            if (_eventWithGameObjectReference != null && _eventWithGameObjectReference.Event != null)
            {
                _eventWithGameObjectReference.Event.Raise(_selectGameObjectReference != null ? _selectGameObjectReference.Call(gameObject) : gameObject);
            }
        }
    }
}
