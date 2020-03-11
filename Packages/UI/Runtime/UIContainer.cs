using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.UI
{
    /// <summary>
    /// A MonoBehaviour that you can add to a `CanvasGroup` and makes it transition based on a `StringVariable` value.
    ///
    /// **TODO**: Add support for differnt transitions. Maybe integrate with DOTween?
    /// </summary>
    [AddComponentMenu("Unity Atoms/UI/Container")]
    public class UIContainer : MonoBehaviour, IAtomListener<string>
    {
        /// <summary>
        /// Variable that we listens to.
        /// </summary>
        [SerializeField]
        private StringVariable _currentUIState = null;

        /// <summary>
        /// A list of states that this `UIContainer` will be visible for.
        /// </summary>
        [SerializeField]
        private List<StringReference> _visibleForStates = null;

        private void Start()
        {
            StateNameChanged(_currentUIState.Value);
        }

        /// <summary>
        /// Handler for when the state is changed.
        /// </summary>
        /// <param name="stateName"></param>
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
            if (_currentUIState.Changed != null)
            {
                _currentUIState.Changed.RegisterListener(this);
            }
        }

        private void OnDestroy()
        {
            if (_currentUIState.Changed != null)
            {
                _currentUIState.Changed.UnregisterListener(this);
            }
        }
    }
}
