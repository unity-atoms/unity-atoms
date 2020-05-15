using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Listeners using Event Reference. Inherits from `AtomListener&lt;T&gt;` and implements `IAtomListener&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The type that we are listening for.</typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomEventReferenceListener<T> : AtomBaseListener<T>, IAtomListener<T>
    {
        /// <summary>
        /// The Event we are listening for as a property.
        /// </summary>
        /// <value>The Event Reference of type `ER`.</value>
        public override AtomEvent<T> Event { get => _eventReference.Event; set => _eventReference.Event = value; }

        /// <summary>
        /// The Event Reference that we are listening to.
        /// </summary>
        [SerializeField]
        private AtomEventReference<T> _eventReference = default(AtomEventReference<T>);
    }
}
