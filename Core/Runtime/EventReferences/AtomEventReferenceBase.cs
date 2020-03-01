using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for `AtomEventReference&lt;...&gt;`.
    /// </summary>
    public abstract class AtomEventReferenceBase
    {
        /// <summary>
        /// Enum for how to use the Event Reference.
        /// </summary>
        public enum Usage
        {
            Event = 0,
            EventInstancer = 1,
            Variable = 2,
            VariableInstancer = 3,
        }

        /// <summary>
        /// Describes how we use the Event Reference.
        /// </summary>
        [SerializeField]
        protected Usage _usage;
    }
}