using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`LateUpdate`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.LateUpdate.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Late Update Hook")]
    public sealed class OnLateUpdateHook : VoidHook
    {
        private void LateUpdate()
        {
            OnHook();
        }
    }
}
