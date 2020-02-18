using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for [`Update`](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html)
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Update Hook")]
    public sealed class OnUpdateHook : VoidHook
    {
        private void Update()
        {
            OnHook();
        }
    }
}
