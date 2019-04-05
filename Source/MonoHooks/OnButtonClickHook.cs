using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityAtoms.Logger;
#endif

namespace UnityAtoms
{
    [RequireComponent(typeof(Button))]
    public class OnButtonClickHook : VoidHook
    {
        private void Awake()
        {
            var button = GetComponent<Button>();
            if (button == null)
            {
#if UNITY_EDITOR
                AtomsLogger.Warning("OnButtonClickHook needs a Button component");
#endif
                return;
            }

            button.onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            var button = GetComponent<Button>();
            if (button == null)
            {
#if UNITY_EDITOR
                AtomsLogger.Warning("OnButtonClickHook needs a Button component");
#endif
                return;
            }

            button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            OnHook(new Void());
        }
    }
}
