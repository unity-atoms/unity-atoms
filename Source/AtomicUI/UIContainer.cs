using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.UI
{
    public class UIContainer : MonoBehaviour, IGameEventListener<string>
    {
        [SerializeField]
        private StringVariable UIStateVariable = null;
        [SerializeField]
        private List<StringConstant> VisibleForStates = null;

        void Start()
        {
            StateNameChanged(UIStateVariable.Value);
        }

        public void OnEventRaised(string stateName)
        {
            StateNameChanged(stateName);
        }

        private void StateNameChanged(string stateName)
        {
            if (VisibleForStates.Exists((state) => state.Value == stateName))
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
            if (UIStateVariable.Changed != null)
            {
                UIStateVariable.Changed.RegisterListener(this);
            }
        }

        private void OnDestroy()
        {
            if (UIStateVariable.Changed != null)
            {
                UIStateVariable.Changed.UnregisterListener(this);
            }
        }
    }
}
