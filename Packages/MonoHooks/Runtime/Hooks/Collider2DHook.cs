using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collider2D`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class Collider2DHook : MonoHook<Collider2D>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public AtomEvent<Collider2DGameObject> EventWithGameObject
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
        private AtomEventReference<Collider2DGameObject> _eventWithGameObjectReference = default(AtomEventReference<Collider2DGameObject>);

        protected override void RaiseWithGameObject(Collider2D value, GameObject gameObject)
        {
            if (EventWithGameObject)
            {
                EventWithGameObject.Raise(new Collider2DGameObject() { Collider2D = value, GameObject = gameObject });
            }
        }
    }
}
