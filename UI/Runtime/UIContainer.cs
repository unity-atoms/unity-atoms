using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityAtoms;

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
        [FormerlySerializedAs("UIStateVariable")]
        [SerializeField]
        private StringVariable _UIStateVariable = null;

        /// <summary>
        /// A list of states that this `UIContainer` will be visible for.
        /// </summary>
        [FormerlySerializedAs("VisibleForStates")]
        [SerializeField]
        private List<StringConstant> _visibleForStates = null;

        private void Start()
        {
            StateNameChanged(_UIStateVariable.Value);
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
