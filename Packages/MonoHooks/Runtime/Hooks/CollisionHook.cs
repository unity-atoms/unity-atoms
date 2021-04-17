using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collision`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class CollisionHook : MonoHook<Collision>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public AtomEvent<CollisionGameObject> EventWithGameObject
        {
            get => _eventWithGameObjectReference != null ? _eventWithGameObjectReference.Event : null;
            set
            {
                if(_eventWithGameObjectReference != null)
                {
                    _eventWithGameObjectReference.Event = value;
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
