using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Base class for all `MonoHook`s of type `Collider2D`.
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    public abstract class Collider2DHook : MonoHook<
        Collider2DEvent,
        Collider2D,
        Collider2DEventReference,
        GameObjectGameObjectFunction>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public Collider2DGameObjectEvent EventWithGameObject
        {
            get => _eventWithGameObjectReference != null ? _eventWithGameObjectReference.GetEvent<Collider2DGameObjectEvent>() : null;
            set
            {
                if (_eventWithGameObjectReference != null)
                {
                    _eventWithGameObjectReference.SetEvent<Collider2DGameObjectEvent>(value);
                }
            }
        }

        [SerializeField]
        private Collider2DGameObjectEventReference _eventWithGameObjectReference = default(Collider2DGameObjectEventReference);

        protected override void RaiseWithGameObject(Collider2D value, GameObject gameObject)
        {
            if (EventWithGameObject)
            {
                EventWithGameObject.Raise(new Collider2DGameObject() { Collider2D = value, GameObject = gameObject });
            }
        }
    }
}
