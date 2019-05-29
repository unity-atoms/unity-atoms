using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Button Click")]
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
            OnHook(new Void());
        }
    }
}
