using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.UI
{
    [AddComponentMenu("Unity Atoms/UI/Container")]
    public class UIContainer : MonoBehaviour, IGameEventListener<string>
    {
        [FormerlySerializedAs("UIStateVariable")]
        [SerializeField]
        private StringVariable _UIStateVariable = null;

        [FormerlySerializedAs("VisibleForStates")]
        [SerializeField]
        private List<StringConstant> _visibleForStates = null;

        private void Start()
        {
            StateNameChanged(_UIStateVariable.Value);
        }

        public void OnEventRaised(string stateName)
        {
            StateNameChanged(stateName);
        }

        private void StateNameChanged(string stateName)
        {
            if (_visibleForStates.Exists((state) => state.Value == stateName))
            {
                GetComponent<CanvasGroup>().alpha = 1f;
                GetComponent<CanvasGroup>().blocksRaycasts = true;
                GetComponent<CanvasGroup>().interactable = true;
            }
            else
            {
                GetComponent<CanvasGroup>().alpha = 0f;
                GetComponent<CanvasGroup>().blocksRaycasts = false;
                GetComponent<CanvasGroup>().interactable = false;
            }
        }

        private void Awake()
        {
            if (_UIStateVariable.Changed != null)
            {
                _UIStateVariable.Changed.RegisterListener(this);
            }
        }

        private void OnDestroy()
        {
            if (_UIStateVariable.Changed != null)
            {
                _UIStateVariable.Changed.UnregisterListener(this);
            }
        }
    }
}
