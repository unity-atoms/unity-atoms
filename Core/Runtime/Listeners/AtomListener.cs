using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Listeners. Inherits from `BaseAtomListener` and `IAtomListener&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The type that we are listening for.</typeparam>
    /// <typeparam name="A">Acion of type `AtomAction&lt;T&gt;`.</typeparam>
    /// <typeparam name="E">Event of type `AtomEvent&lt;T&gt;`.</typeparam>
    /// <typeparam name="UER">Unity Event of type `UnityEvent&lt;T&gt;`.</typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomListener<T, A, E, UER> : BaseAtomListener, IAtomListener<T>
        where A : AtomAction<T>
        where E : AtomEvent<T> where UER : UnityEvent<T>
    {
        /// <summary>
        /// The Event that we are listening to.
        /// </summary>
        [FormerlySerializedAs("Event")]
        [SerializeField]
        private E _event = null;

        /// <summary>
        /// The Event we are listening for as a proeprty.
        /// </summary>
        /// <value>The Event of type `E`.</value>
        public E Event { get { return _event; } set { _event = value; } }

        /// <summary>
        /// The Unity Event responses.
        /// NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).
        /// </summary>
        [FormerlySerializedAs("UnityEventResponse")]
        public UER _unityEventResponse = null;

        /// <summary>
        /// The Action responses;
        /// </summary>
        /// <typeparam name="A">The Action type.</typeparam>
        /// <returns>A `List&lt;A&gt;` of Actions.</returns>
        [FormerlySerializedAs("GameActionResponses")]
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
            if (_unityEventResponse != null) { _unityEventResponse.Invoke(item); }
            for (int i = 0; _actionResponses != null && i < _actionResponses.Count; ++i)
            {
                _actionResponses[i].Do(item);
            }
        }
    }

    /// <summary>
    /// Generic base class for Listeners. Inherits from `BaseAtomListener` and `IAtomListener&lt;T1, T2&gt;`
    /// </summary>
    /// <typeparam name="T1">The first type that we are listening for.</typeparam>
    /// <typeparam name="T2">The second type that we are listening for.</typeparam>
    /// <typeparam name="A">Acion of type `AtomAction&lt;T1, T2&gt;`.</typeparam>
    /// <typeparam name="E">Event of type `AtomEvent&lt;T1, T2&gt;`.</typeparam>
    /// <typeparam name="UER">Unity Event of type `UnityEvent&lt;T1, T2&gt;`.</typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomListener<T1, T2, A, E, UER> : BaseAtomListener, IAtomListener<T1, T2>
        where A : AtomAction<T1, T2>
        where E : AtomEvent<T1, T2>
        where UER : UnityEvent<T1, T2>
    {
        /// <summary>
        /// The Event that we are listening to.
        /// </summary>
        [FormerlySerializedAs("Event")]
        [SerializeField]
        private E _event;

        /// <summary>
        /// The Event we are listening for as a proeprty.
        /// </summary>
        /// <value>The Event of type `E`.</value>
        public E Event { get { return _event; } set { _event = value; } }

        /// <summary>
        /// The Unity Event responses.
        /// NOTE: This variable is public due to this bug: https://issuetracker.unity3d.com/issues/events-generated-by-the-player-input-component-do-not-have-callbackcontext-set-as-their-parameter-type. Will be changed back to private when fixed (this could happen in a none major update).
        /// </summary>
        [FormerlySerializedAs("UnityEventResponse")]
        public UER _unityEventResponse = null;

        /// <summary>
        /// The Action responses;
        /// </summary>
        /// <typeparam name="A">The Action type.</typeparam>
        /// <returns>A `List&lt;A&gt;` of Actions.</returns>
        [FormerlySerializedAs("GameActionResponses")]
        [SerializeField]
        private List<A> _actionResponses = new List<A>();

        private void OnEnable()
        {
            if (_event == null) return;
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (_event == null) return;
            Event.UnregisterListener(this);
        }

        /// <summary>
        /// Handler for when the Event gets raised.
        /// </summary>
        /// <param name="first">The first Event type.</param>
        /// <param name="second">The second Event type.</param>
        public void OnEventRaised(T1 first, T2 second)
        {
            if (_unityEventResponse != null) { _unityEventResponse.Invoke(first, second); }
            for (int i = 0; _actionResponses != null && i < _actionResponses.Count; ++i)
            {
                _actionResponses[i].Do(first, second);
            }
        }
    }
}
