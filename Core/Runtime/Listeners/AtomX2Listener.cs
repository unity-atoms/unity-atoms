using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for X2 Listeners. Inherits from `AtomBaseListener` and implements `IAtomListener&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The type that we are listening for.</typeparam>
    /// <typeparam name="A">Acion of type T.</typeparam>
    /// <typeparam name="V">Variable of type T.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Event x 2 of type T.</typeparam>
    /// <typeparam name="F">Function of type T => T.</typeparam>
    /// <typeparam name="VI">Variable Instancer of type T.</typeparam>
    /// <typeparam name="E2R">Event x 2 Reference of type T.</typeparam>
    /// <typeparam name="UER">UnityEvent of type T.</typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomX2Listener<T, A, V, E1, E2, F, VI, E2R, UER> : AtomBaseListener, IAtomListener<T, T>
        where A : AtomAction<T, T>
        where V : AtomVariable<T, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, T, E1, E2, F>
        where E2R : AtomEventX2Reference<T, V, E1, E2, F, VI>
        where UER : UnityEvent<T, T>
    {
        /// <summary>
        /// The Event we are listening for as a property.
        /// </summary>
        /// <value>The Event Reference of type `E2R`.</value>
        public E2R EventReference { get => _eventReference; set => _eventReference = value; }

        /// <summary>
        /// The Event Reference that we are listening to.
        /// </summary>
        [SerializeField]
        private E2R _eventReference = null;

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
            if (EventReference.Event == null) return;
            EventReference.Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            if (EventReference.Event == null) return;
            EventReference.Event.UnregisterListener(this);
        }

        /// <summary>
        /// Handler for when the Event gets raised.
        /// </summary>
        /// <param name="first">The first Event type.</param>
        /// <param name="second">The second Event type.</param>
        public void OnEventRaised(T first, T second)
        {
            _unityEventResponse?.Invoke(first, second);
            for (int i = 0; _actionResponses != null && i < _actionResponses.Count; ++i)
            {
                _actionResponses[i].Do(first, second);
            }
        }

        /// <summary>
        /// Helper to regiser as listener callback
        /// </summary>
        public void DebugLog(T item1, T item2)
        {
            Debug.Log(item1.ToString() + " <- " + item2);
        }
    }
}
