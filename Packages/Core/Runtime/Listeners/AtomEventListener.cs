using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Listeners using Event. Inherits from `AtomListener&lt;T&gt;` and implements `IAtomListener&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The type that we are listening for.</typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomEventListener<T> : AtomBaseListener<T>, IAtomListener<T>
    {
        /// <summary>
        /// The Event we are listening for as a property.
        /// </summary>
        /// <value>The Event of type `E`.</value>
        public override AtomEvent<T> Event { get => _event; set => _event = value; }

        /// <summary>
        /// The Event that we are listening to.
        /// </summary>
        [SerializeField]
        private AtomEvent<T> _event = null;
    }
}
