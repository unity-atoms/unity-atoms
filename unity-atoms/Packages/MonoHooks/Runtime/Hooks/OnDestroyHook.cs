using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`OnDestroy`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnDestroy.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Destroy Hook")]
    public sealed class OnDestroyHook : VoidHook
    {
        private void OnDestroy()
        {
            OnHook();
        }
    }
}
