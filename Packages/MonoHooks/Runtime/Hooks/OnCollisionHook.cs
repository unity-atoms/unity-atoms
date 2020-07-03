using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`OnCollisionEnter`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter.html), [`OnCollisionExit`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionExit.html) and [`OnCollisionStay`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionStay.html)
    /// </summary>
    [EditorIcon ("atom-icon-delicate")]
    [AddComponentMenu ("Unity Atoms/Hooks/On Collision Hook")]
    public sealed class OnCollisionHook : CollisionHook
    {
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionEnter`
        /// </summary>
        [SerializeField]
        private bool _triggerOnEnter = default (bool);
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionExit`
        /// </summary>
        [SerializeField]
        private bool _triggerOnExit = default (bool);
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionStay`
        /// </summary>
        [SerializeField]
        private bool _triggerOnStay = default (bool);

        private void OnCollisionEnter (Collision other)
        {
            if (_triggerOnEnter) OnHook (other);
        }

        private void OnCollisionExit (Collision other)
        {
            if (_triggerOnExit) OnHook (other);
        }

        private void OnCollisionStay (Collision other)
        {
            if (_triggerOnStay) OnHook (other);
        }
    }
}