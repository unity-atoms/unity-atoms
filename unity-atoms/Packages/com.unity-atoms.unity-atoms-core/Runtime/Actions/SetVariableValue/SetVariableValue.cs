using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// Base class for all SetVariableValue Actions. Inherits from `AtomAction`.
    /// </summary>
    /// <typeparam name="T">The type of the Variable to set.</typeparam>
    /// <typeparam name="P">A IPair of type T.</typeparam>
    /// <typeparam name="V">A Variable class of type `T` to set.</typeparam>
    /// <typeparam name="C">A Constant class of type `T`.</typeparam>
    /// <typeparam name="R">A Reference of type `T`.</typeparam>
    /// <typeparam name="E1">An Event of type `T`.</typeparam>
    /// <typeparam name="E2">An Event x 2 of type `T`.</typeparam>
    /// <typeparam name="F">A Function x 2 of type `T`.</typeparam>
    /// <typeparam name="VI">A Variable Instancer of type `T`.</typeparam>
    public abstract class SetVariableValue<T, P, V, C, R, E1, E2, F, VI> : AtomAction
        where P : struct, IPair<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
        where V : AtomVariable<T, P, E1, E2, F>
        where C : AtomBaseVariable<T>
        where R : AtomReference<T, P, C, V, E1, E2, F, VI>
        where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
    {
        /// <summary>
        /// The Variable to set.
        /// </summary>
        [SerializeField]
        private V _variable = null;

        /// <summary>
        /// The value to use.
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
