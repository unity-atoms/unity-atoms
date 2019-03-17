using UnityEngine;

namespace UnityAtoms
{

    public class OnAwakeHook : VoidHook
    {
        [SerializeField]
        private VoidListener listener = null;
        [SerializeField]
        private VoidGameObjectListener listenerWithGO = null;

        private void Awake()
        {
            // This is needed because it's not certain that OnEnable on all scripts are called before Awake on all scripts
            if (Event != null && listener != null)
            {
                Event.RegisterListener(listener);
            }
            if (EventWithGORef != null && listenerWithGO != null)
            {
                EventWithGORef.RegisterListener(listenerWithGO);
            }

            OnHook(new Void());
        }
    }
}
