using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Listeners using Event. Inherits from `AtomListener&lt;T, E, UER&gt;` and implements `IAtomListener&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The type that we are listening for.</typeparam>
    /// <typeparam name="E">Event of type `T`.</typeparam>
    /// <typeparam name="UER">UnityEvent of type `T`.</typeparam>
    [EditorIcon("atom-icon-orange")]
    public abstract class AtomEventListener<T, E, UER> : AtomBaseListener<T, E, UER>, IAtomListener<T>
        where E : AtomEvent<T>
        where UER : UnityEvent<T>
    {
        /// <summary>
        /// The Event we are listening for as a property.
        /// </summary>
        /// <value>The Event of type `E`.</value>
        public override E Event { get => _event; set => _event = value; }

        /// <summary>
        /// The Event that we are listening to.
        /// </summary>
        [SerializeField]
        private E _event = null;
    }
}
