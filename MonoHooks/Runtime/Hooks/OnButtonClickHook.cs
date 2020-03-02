using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Mono Hook for On Button Click
    /// </summary>
    [EditorIcon("atom-icon-delicate")]
    [AddComponentMenu("Unity Atoms/Hooks/On Button Click Hook")]
    [RequireComponent(typeof(Button))]
    public sealed class OnButtonClickHook : VoidHook
    {
        private void Awake()
        {
            var button = GetComponent<Button>();
            button.onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            var button = GetComponent<Button>();
            button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            OnHook();
        }
    }
}
