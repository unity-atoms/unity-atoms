using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`OnTriggerEnter`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter.html), [`OnTriggerExit`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerExit.html) and [`OnTriggerStay`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerStay.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Trigger Hook")]
    public sealed class OnTriggerHook : ColliderHook
    {
        /// <summary>
        /// Set to true if Event should be triggered on `OnTriggerEnter`
        /// </summary>
        [SerializeField]
        private bool _triggerOnEnter = default(bool);
        /// <summary>
        /// Set to true if Event should be triggered on `OnTriggerExit`
        /// </summary>
        [SerializeField]
        private bool _triggerOnExit = default(bool);
        /// <summary>
        /// Set to true if Event should be triggered on `OnTriggerStay`
        /// </summary>
        [SerializeField]
        private bool _triggerOnStay = default(bool);

        private void OnTriggerEnter(Collider other)
        {
            if (_triggerOnEnter) OnHook(other);
        }

        private void OnTriggerExit(Collider other)
        {
            if (_triggerOnExit) OnHook(other);
        }

        private void OnTriggerStay(Collider other)
        {
            if (_triggerOnStay) OnHook(other);
        }
    }
}
