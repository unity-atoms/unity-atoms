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
    /// <typeparam name="F">A Function x 2 of type `type`.</typeparam>
    /// <typeparam name="VI">A Variable Instancer of type `type`.</typeparam>
    public abstract class SetVariableValue<T, V, C, R, E1, E2, F, VI> : VoidAction
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
        where V : AtomVariable<T, E1, E2, F>
        where C : AtomBaseVariable<T>
        where R : AtomReference<T, C, V, E1, E2, F, VI>
        where VI : AtomVariableInstancer<V, T, E1, E2, F>
    {
        /// <summary>
        /// The Variable to set.
        /// </summary>
        [SerializeField]
        private V _variable = null;

        /// <summary>
        /// The value to set.
        /// </summary>
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
