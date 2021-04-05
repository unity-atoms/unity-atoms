using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collision2D`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class Collision2DHook : MonoHook<Collision2D>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public AtomEvent<Collision2DGameObject> EventWithGameObject
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
        private Collision2DGameObjectEventReference _eventWithGameObjectReference = default(Collision2DGameObjectEventReference);

        protected override void RaiseWithGameObject(Collision2D value, GameObject gameObject)
        {
            if(EventWithGameObject)
            {
                EventWithGameObject.Raise(new Collision2DGameObject() { Collision2D = value, GameObject = gameObject });
            }
        }
    }
}
