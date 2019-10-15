using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`OnTriggerEnter2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerEnter2D.html), [`OnTriggerExit2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerExit2D.html) and [`OnTriggerStay2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnTriggerStay2D.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Trigger 2D")]
    public sealed class OnTrigger2DHook : Collider2DHook
    {
        /// <summary>
        /// Set to true if Event should be triggered on `OnTriggerEnter2D`
        /// </summary>
        [SerializeField]
        private bool _triggerOnEnter;
        /// <summary>
        /// Set to true if Event should be triggered on `OnTriggerExit2D`
        /// </summary>
        [SerializeField]
        private bool _triggerOnExit;
        /// <summary>
        /// Set to true if Event should be triggered on `OnTriggerStay2D`
        /// </summary>
        [SerializeField]
        private bool _triggerOnStay;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (_triggerOnEnter) OnHook(other);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (_triggerOnExit) OnHook(other);
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (_triggerOnStay) OnHook(other);
        }
    }
}
