using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// The most basic Listener. Can use every type of AtomEvent but doesn't support its value. Inherits from `AtomBaseListener` and implements `IAtomListener`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Void Listener")]
    public sealed class VoidListener : AtomBaseListener, IAtomListener
    {
        /// <summary>
        /// The Event that we are listening to.
        /// </summary>
        [SerializeField]
        private AtomEventBase _event = null;

        /// <summary>
        /// The Event we are listening for as a property.
        /// </summary>
        public AtomEventBase Event { get { return _event; } set { _event = value; } }

        /// <summary>
        /// The Unity Event responses.
        /// NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).
        /// </summary>
        [SerializeField]
        public UnityEvent _unityEventResponse = null;

        /// <summary>
        /// The Action responses;
        /// </summary>
        /// <returns>A `List&lt;AtomAction&gt;` of Actions.</returns>
        [SerializeField]
        private List<AtomAction> _actionResponses = new List<AtomAction>();

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
        public void OnEventRaised()
        {
            _unityEventResponse?.Invoke();
            for (int i = 0; _actionResponses != null && i < _actionResponses.Count; ++i)
            {
                _actionResponses[i].Do();
            }
        }
    }
}