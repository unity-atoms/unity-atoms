using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// Base class for all SetVariableValue Actions. Inherits from `VoidAction`.
    /// </summary>
    /// <typeparam name="T">The type of the Variable to set.</typeparam>
    /// <typeparam name="V">A Variable class of type `type` to set.</typeparam>
    /// <typeparam name="C">A Constant class of type `type` to set.</typeparam>
    /// <typeparam name="R">A Reference of type `type`.</typeparam>
    /// <typeparam name="E1">An Event of type `type`.</typeparam>
    /// <typeparam name="E2">An Event x 2 of type `type`.</typeparam>
    public abstract class SetVariableValue<T, V, C, R, E1, E2> : VoidAction
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where V : AtomVariable<T, E1, E2>
        where C : AtomBaseVariable<T>
        where R : AtomReference<T, V, C>
    {
        /// <summary>
        /// The Variable to set.
        /// </summary>
        [FormerlySerializedAs("Variable")]
        [SerializeField]
        private V _variable = null;

        /// <summary>
        /// The value to set.
        /// </summary>
        [FormerlySerializedAs("Value")]
        [SerializeField]
        private R _value = null;

        /// <summary>
        /// Perform the action.
        /// </summary>
        public override void Do()
        {
            _variable.Value = _value.Value;
        }
    }
}
