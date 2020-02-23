using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Listeners. Inherits from `AtomBaseListener` and implements `IAtomListener&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The type that we are listening for.</typeparam>
    /// <typeparam name="A">Acion of type T.</typeparam>
    /// <typeparam name="V">Variable of type T.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Event x 2 of type T.</typeparam>
    /// <typeparam name="F">Function of type T => T.</typeparam>
    /// <typeparam name="VI">Variable Instancer of type T.</typeparam>
    /// <typeparam name="ER">Event Reference of type T.</typeparam>
    /// <typeparam name="UER">UnityEvent of type T.</typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomListener<T, A, V, E1, E2, F, VI, ER, UER> : AtomBaseListener, IAtomListener<T>
        where A : AtomAction<T>
        where V : AtomVariable<T, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, T, E1, E2, F>
        where ER : AtomEventReference<T, V, E1, E2, F, VI>
        where UER : UnityEvent<T>
    {
        /// <summary>
        /// The Event we are listening for as a property.
        /// </summary>
        /// <value>The Event of type `E1`.</value>
        public E1 Event { get => _eventReference.Event; set => _eventReference.Event = value; }

        /// <summary>
        /// The Event that we are listening to.
        /// </summary>
        [SerializeField]
        private ER _eventReference = null;

        /// <summary>
        /// The Unity Event responses.
        /// NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).
        /// </summary>
        public UER _unityEventResponse = null;

        /// <summary>
        /// The Action responses;
        /// </summary>
        /// <typeparam name="A">The Action type.</typeparam>
        /// <returns>A `List&lt;A&gt;` of Actions.</returns>
        [SerializeField]
        private List<A> _actionResponses = new List<A>();

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
        public void OnEventRaised(T item)
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
        public void DebugLog(T item)
        {
            Debug.Log(item.ToString());
        }
    }
}
