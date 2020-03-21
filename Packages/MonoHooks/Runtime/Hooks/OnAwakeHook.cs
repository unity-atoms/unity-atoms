using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`Awake`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html).
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Awake Hook")]
    public sealed class OnAwakeHook : VoidHook
    {
        /// <summary>
        /// Listener
        /// </summary>
        [SerializeField]
        private VoidBaseEventReferenceListener _listener = null;

        /// <summary>
        /// Listener with GameObject reference
        /// </summary>
        [SerializeField]
        private GameObjectEventReferenceListener _gameObjectListener = null;

        private void Awake()
        {
            // This is needed because it's not certain that OnEnable on all scripts are called before Awake on all scripts
            if (_event != null && _listener != null)
            {
                _event.RegisterListener(_listener);
            }
            if (_eventWithGameObjectReference != null && _gameObjectListener != null)
            {
                _eventWithGameObjectReference.RegisterListener(_gameObjectListener);
            }

            OnHook();
        }
    }
}
