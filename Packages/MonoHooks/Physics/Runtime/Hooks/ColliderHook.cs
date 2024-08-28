using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collider`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class ColliderHook : MonoHook<
        ColliderEvent,
        Collider,
        ColliderEventReference,
        GameObjectGameObjectFunction>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public ColliderGameObjectEvent EventWithGameObject
        {
            get => _eventWithGameObjectReference != null ? _eventWithGameObjectReference.GetEvent<ColliderGameObjectEvent>() : null;
            set
            {
                if (_eventWithGameObjectReference != null)
                {
                    _eventWithGameObjectReference.SetEvent<ColliderGameObjectEvent>(value);
                }
            }
        }

        [SerializeField]
        private ColliderGameObjectEventReference _eventWithGameObjectReference = default(ColliderGameObjectEventReference);

        protected override void RaiseWithGameObject(Collider value, GameObject gameObject)
        {
            if (EventWithGameObject)
            {
                EventWithGameObject.Raise(new ColliderGameObject() { Collider = value, GameObject = gameObject });
            }
        }
    }
}
