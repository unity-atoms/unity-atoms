using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`Awake`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html).
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Awake")]
    public sealed class OnAwakeHook : VoidHook
    {
        /// <summary>
        /// Listener
        /// </summary>
        [SerializeField]
        private VoidListener _listener;

        /// <summary>
        /// Listener with GameObject reference
        /// </summary>
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
