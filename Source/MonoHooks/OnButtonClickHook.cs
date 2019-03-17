using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms
{
    public class OnButtonClickHook : VoidHook
    {
        private void Awake()
        {
            GetComponent<Button>().onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            GetComponent<Button>().onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            OnHook(new Void());
        }
    }
}