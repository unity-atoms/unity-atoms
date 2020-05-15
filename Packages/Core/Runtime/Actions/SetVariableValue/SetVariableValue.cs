using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// Base class for all SetVariableValue Actions. Inherits from `AtomAction`.
    /// </summary>
    /// <typeparam name="T">The type of the Variable to set.</typeparam>
    public abstract class SetVariableValue<T> : AtomAction
    {
        /// <summary>
        /// The Variable to set.
        /// </summary>
        [SerializeField]
        private AtomVariable<T> _variable = null;

        /// <summary>
        /// The value to use.
        /// </summary>
        [SerializeField]
        private AtomReference<T> _value = null;

        /// <summary>
        /// Perform the action.
        /// </summary>
        public override void Do()
        {
            _variable.Value = _value.Value;
        }
    }
}
