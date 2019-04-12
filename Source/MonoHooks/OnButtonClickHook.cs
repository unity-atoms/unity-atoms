using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.Logger;

namespace UnityAtoms
{
    [RequireComponent(typeof(Button))]
    public sealed class OnButtonClickHook : VoidHook
    {
        private void Awake()
        {
            var button = GetComponent<Button>();
            if (button == null)
            {
                AtomsLogger.Warning("OnButtonClickHook needs a Button component");
                return;
            }

            button.onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            var button = GetComponent<Button>();
            if (button == null)
            {
                AtomsLogger.Warning("OnButtonClickHook needs a Button component");
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
