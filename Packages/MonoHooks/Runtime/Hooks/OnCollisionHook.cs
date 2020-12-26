using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`OnCollisionEnter`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter.html), [`OnCollisionExit`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionExit.html) and [`OnCollisionStay`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionStay.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Collision Hook")]
    public sealed class OnCollisionHook : CollisionHook
    {
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionEnter`
        /// </summary>
        [SerializeField]
        private bool _collisionOnEnter = default(bool);
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionExit`
        /// </summary>
        [SerializeField]
        private bool _collisionOnExit = default(bool);
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionStay`
        /// </summary>
        [SerializeField]
        private bool _collisionOnStay = default(bool);

        private void OnCollisionEnter(Collision other)
        {
            if(_collisionOnEnter) OnHook(other);
        }

        private void OnCollisionExit(Collision other)
        {
            if(_collisionOnExit) OnHook(other);
        }

        private void OnCollisionStay(Collision other)
        {
            if(_collisionOnStay) OnHook(other);
        }
    }
}
