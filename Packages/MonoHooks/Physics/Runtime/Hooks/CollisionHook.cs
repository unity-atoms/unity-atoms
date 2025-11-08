using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collision`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class CollisionHook : MonoHook<
        CollisionEvent,
        Collision,
        CollisionEventReference,
        GameObjectGameObjectFunction>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public CollisionGameObjectEvent EventWithGameObject
        {
            get => _eventWithGameObjectReference != null ? _eventWithGameObjectReference.GetEvent<CollisionGameObjectEvent>() : null;
            set
            {
                if(_eventWithGameObjectReference != null)
                {
                    _eventWithGameObjectReference.SetEvent<CollisionGameObjectEvent>(value);
                }
            }
        }

        [SerializeField]
        private CollisionGameObjectEventReference _eventWithGameObjectReference = default(CollisionGameObjectEventReference);

        protected override void RaiseWithGameObject(Collision value, GameObject gameObject)
        {
            if(EventWithGameObject)
            {
                EventWithGameObject.Raise(new CollisionGameObject() { Collision = value, GameObject = gameObject });
            }
        }
    }
}
