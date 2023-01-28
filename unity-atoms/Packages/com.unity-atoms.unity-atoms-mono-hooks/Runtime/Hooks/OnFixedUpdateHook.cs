using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`FixedUpdate`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Fixed Update Hook")]
    public sealed class OnFixedUpdateHook : VoidHook
    {
        private void FixedUpdate()
        {
            OnHook();
        }
    }
}
