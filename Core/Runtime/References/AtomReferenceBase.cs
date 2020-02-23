using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for `AtomReference&lt;T, C, V, E1, E2, F, VI&gt;`.
    /// </summary>
    public abstract class AtomReferenceBase
    {
        /// <summary>
        /// Enum for how to use the Reference.
        /// </summary>
        public enum Usage
        {
            Value = 0,
            Constant = 1,
            Variable = 2,
            VariableInstancer = 3,
        }

        /// <summary>
        /// Descries how we use the Reference and where the value comes from.
        /// </summary>
        [SerializeField]
        protected Usage _usage;
    }
}