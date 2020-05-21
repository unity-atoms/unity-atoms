using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Listeners using Event Reference. Inherits from `AtomListener&lt;T&gt;` and implements `IAtomListener&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The type that we are listening for.</typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomListener<T> : MonoBehaviour, IAtomListener<T>
    {
        /// <summary>
        /// The Event we are listening for as a property.
        /// </summary>
        /// <value>The Event Reference of type `ER`.</value>
        public AtomEvent<T> Event { get => _eventReference.Event; set => _eventReference.Event = value; }

        /// <summary>
        /// A description of the Listener made for documentation purposes.
        /// </summary>
        [SerializeField]
        [TextArea(3, 6)]
        private string _developerDescription;

        /// <summary>
        /// The Event Reference that we are listening to.
        /// </summary>
        [SerializeField]
        private AtomEventReference<T> _eventReference = default(AtomEventReference<T>);

        /// <summary>
        /// The Unity Event responses.
        /// NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).
        /// </summary>
        public UnityEvent<T> _unityEventResponse = null;

        /// <summary>
        /// The Action responses;
        /// </summary>
        /// <typeparam name="A">The Action type.</typeparam>
        /// <returns>A `List&lt;A&gt;` of Actions.</returns>
        [SerializeField]
        private List<AtomAction> _actionResponses = new List<AtomAction>();

        [SerializeField]
        private bool _replayEventBufferOnRegister = true;

        private void OnEnable()
        {
            if (Event == null) return;
            Event.RegisterListener(this, _replayEventBufferOnRegister);
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
        public void OnEventRaised(T item)
        {
            _unityEventResponse?.Invoke(item);
            for (int i = 0; _actionResponses != null && i < _actionResponses.Count; ++i)
            {
                var action = _actionResponses[i];

                if (action == null) continue;

                if (action is AtomAction<T> actionWithParam)
                {
                    actionWithParam.Do(item);
                }
                else
                {
                    action.Do();
                }
            }
        }

        /// <summary>
        /// Helper to register as listener callback
        /// </summary>
        public void DebugLog(T item)
        {
            Debug.Log(item.ToString());
        }
    }
}
