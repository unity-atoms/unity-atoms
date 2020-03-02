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
        GameObjectGameObjectFunction>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public Collider2DGameObjectEvent EventWithGameObjectReference { get => _eventWithGameObjectReference; set => _eventWithGameObjectReference = value; }

        [SerializeField]
        private Collider2DGameObjectEvent _eventWithGameObjectReference;

        protected override void RaiseWithGameObject(Collider2D value, GameObject gameObject)
        {
            EventWithGameObjectReference.Raise(new Collider2DGameObject() { Collider2D = value, GameObject = gameObject });
        }
    }
}
