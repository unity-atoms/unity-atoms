using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`Start`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Start Hook")]
    public sealed class OnStartHook : VoidHook
    {
        private void Start()
        {
            OnHook();
        }
    }
}
