using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for `OnPointerDown`
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Pointer Down")]
    public sealed class OnPointerDownHook : VoidHook, IPointerDownHandler
    {
        public void OnPointerDown(PointerEventData eventData)
        {
            OnHook(new Void());
        }
    }
}
