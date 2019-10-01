using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms.Examples
{
    [RequireComponent(typeof(Button))]
    public sealed class RaiseEventOnButtonClick : MonoBehaviour
    {
        [SerializeField]
        private VoidEvent _event;

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
            _event.Raise();
        }
    }
}
