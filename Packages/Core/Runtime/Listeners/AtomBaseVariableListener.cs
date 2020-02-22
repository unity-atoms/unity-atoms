using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// A listener of type `BaseAtomVariable`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    public class AtomBaseVariableListener : AtomBaseListener, IAtomListener<AtomBaseVariable>
    {
        /// <summary>
        /// The Event we are listening for as a property.
        /// </summary>
        /// <value>The Event of type `AtomBaseVariableEvent`.</value>
        public AtomBaseVariableEvent Event { get => _event; set => _event = value; }

        /// <summary>
        /// The Event that we are listening to.
        /// </summary>
        [SerializeField]
        private AtomBaseVariableEvent _event = null;

        /// <summary>
        /// The Unity Event responses.
        /// NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).
        /// </summary>
        public AtomBaseVariableUnityEvent _unityEventResponse = null;

        /// <summary>
        /// The Action responses;
        /// </summary>
        /// <typeparam name="A">The Action type.</typeparam>
        /// <returns>A `List&lt;A&gt;` of Actions.</returns>
        [SerializeField]
        private List<AtomBaseVariableAction> _actionResponses = new List<AtomBaseVariableAction>();

        private void OnEnable()
        {
            if (Event == null) return;
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (Event == null) return;
            Event.UnregisterListener(this);
        }

        /// <summary>
        /// Handler for when the Event gets raised.
        /// </summary>
        /// <param name="item">The Event type.</param>
        public void OnEventRaised(AtomBaseVariable item)
        {
            _unityEventResponse?.Invoke(item);
            for (int i = 0; _actionResponses != null && i < _actionResponses.Count; ++i)
            {
                _actionResponses[i].Do(item);
            }
        }

        /// <summary>
        /// Helper to regiser as listener callback
        /// </summary>
        public void DebugLog(AtomBaseVariable item)
        {
            if (item != null)
                Debug.Log(item.ToString());
        }
    }
}
