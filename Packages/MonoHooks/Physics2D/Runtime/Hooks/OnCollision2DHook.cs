using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`OnCollisionEnter2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionEnter2D.html), [`OnCollisionExit2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionExit2D.html) and [`OnCollisionStay2D`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnCollisionStay2D.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Collision 2D Hook")]
    public sealed class OnCollision2DHook : Collision2DHook
    {
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionEnter2D`
        /// </summary>
        [SerializeField]
        private bool _collisionOnEnter = default(bool);
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionExit2D`
        /// </summary>
        [SerializeField]
        private bool _collisionOnExit = default(bool);
        /// <summary>
        /// Set to true if Event should be triggered on `OnCollisionStay2D`
        /// </summary>
        [SerializeField]
        private bool _collisionOnStay = default(bool);

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(_collisionOnEnter) OnHook(other);
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if(_collisionOnExit) OnHook(other);
        }

        private void OnCollisionStay2D(Collision2D other)
        {
            if(_collisionOnStay) OnHook(other);
        }
    }
}
