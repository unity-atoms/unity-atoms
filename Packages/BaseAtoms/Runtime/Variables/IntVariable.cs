using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `int`. Inherits from `EquatableAtomVariable&lt;int, IntPair, IntEvent, IntPairEvent, IntIntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Int", fileName = "IntVariable")]
    public sealed class IntVariable : EquatableAtomVariable<int, IntPair, IntEvent, IntPairEvent, IntIntFunction>
    {
        /// <summary>
        /// Add value to Variable.
        /// </summary>
        /// <param name="value">Value to add.</param>
        public void Add(int value) => Value += value;

        /// <summary>
        /// Add variable value to Variable.
        /// </summary>
        /// <param name="variable">Variable with value to add.</param>
        public void Add(AtomBaseVariable<int> variable) => Add(variable.Value);

        /// <summary>
        /// Subtract value from Variable.
        /// </summary>
        /// <param name="value">Value to subtract.</param>
        public void Subtract(int value) => Value -= value;

        /// <summary>
        /// Subtract variable value from Variable.
        /// </summary>
        /// <param name="variable">Variable with value to subtract.</param>
        public void Subtract(AtomBaseVariable<int> variable) => Subtract(variable.Value);

        /// <summary>
        /// Multiply variable by value.
        /// </summary>
        /// <param name="value">Value to multiple by.</param>
        public void MultiplyBy(int value) => Value *= value;

        /// <summary>
        /// Multiply variable by Variable value.
        /// </summary>
        /// <param name="variable">Variable with value to multiple by.</param>
        public void MultiplyBy(AtomBaseVariable<int> variable) => MultiplyBy(variable.Value);

        /// <summary>
        /// Divide Variable by value.
        /// </summary>
        /// <param name="value">Value to divide by.</param>
        public void DivideBy(int value) => Value /= value;

        /// <summary>
        /// Divide Variable by Variable value.
        /// </summary>
        /// <param name="variable">Variable value to divide by.</param>
        public void DivideBy(AtomBaseVariable<int> variable) => DivideBy(variable.Value);
    }
}
