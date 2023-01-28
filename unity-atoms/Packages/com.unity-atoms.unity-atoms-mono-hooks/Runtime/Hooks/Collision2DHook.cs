using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collision2D`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class Collision2DHook : MonoHook<
        Collision2DEvent,
        Collision2D,
        Collision2DEventReference,
        GameObjectGameObjectFunction>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public Collision2DGameObjectEvent EventWithGameObject
        {
            get => _eventWithGameObjectReference != null ? _eventWithGameObjectReference.GetEvent<Collision2DGameObjectEvent>() : null;
            set
            {
                if(_eventWithGameObjectReference != null)
                {
                    _eventWithGameObjectReference.SetEvent<Collision2DGameObjectEvent>(value);
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
