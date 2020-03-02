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
        GameObjectGameObjectFunction>
    {
        /// <summary>
        /// Event including a GameObject reference.
        /// </summary>
        public ColliderGameObjectEvent EventWithGameObjectReference { get => _eventWithGameObjectReference; set => _eventWithGameObjectReference = value; }

        [SerializeField]
        private ColliderGameObjectEvent _eventWithGameObjectReference;

        protected override void RaiseWithGameObject(Collider value, GameObject gameObject)
        {
            EventWithGameObjectReference.Raise(new ColliderGameObject() { Collider = value, GameObject = gameObject });
        }
    }
}
