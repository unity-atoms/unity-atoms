using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public sealed class OnAwakeHook : VoidHook
    {
        [FormerlySerializedAs("listener")]
        [SerializeField]
        private VoidListener _listener;

        [FormerlySerializedAs("listenerWithGO")]
        [SerializeField]
        private VoidGameObjectListener _listenerWithGameObject;

        private void Awake()
        {
            // This is needed because it's not certain that OnEnable on all scripts are called before Awake on all scripts
            if (Event != null && _listener != null)
            {
                Event.RegisterListener(_listener);
            }
            if (EventWithGameObjectReference != null && _listenerWithGameObject != null)
            {
                EventWithGameObjectReference.RegisterListener(_listenerWithGameObject);
            }

            OnHook(new Void());
        }
    }
}
