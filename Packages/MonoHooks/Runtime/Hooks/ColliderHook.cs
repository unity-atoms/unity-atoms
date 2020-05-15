using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collider`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class ColliderHook : MonoHook<Collider>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public AtomEvent<ColliderGameObject> EventWithGameObject
        {
            get => _eventWithGameObjectReference != null ? _eventWithGameObjectReference.Event : null;
            set
            {
                if (_eventWithGameObjectReference != null)
                {
                    _eventWithGameObjectReference.Event = value;
                }
            }
        }

        [SerializeField]
        private AtomEventReference<ColliderGameObject> _eventWithGameObjectReference = default(AtomEventReference<ColliderGameObject>);

        protected override void RaiseWithGameObject(Collider value, GameObject gameObject)
        {
            if (EventWithGameObject)
            {
                EventWithGameObject.Raise(new ColliderGameObject() { Collider = value, GameObject = gameObject });
            }
        }
    }
}
