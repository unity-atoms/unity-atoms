using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `float`. Inherits from `EquatableAtomVariable&lt;float, FloatPair, FloatEvent, FloatPairEvent, FloatFloatFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Float", fileName = "FloatVariable")]
    public sealed class FloatVariable : EquatableAtomVariable<float, FloatPair, FloatEvent, FloatPairEvent, FloatFloatFunction>
    {
        /// <summary>
        /// Add value to Variable.
        /// </summary>
        /// <param name="value">Value to add.</param>
        public void Add(float value) => Value += value;

        /// <summary>
        /// Add variable value to Variable.
        /// </summary>
        /// <param name="variable">Variable with value to add.</param>
        public void Add(AtomBaseVariable<float> variable) => Add(variable.Value);

        /// <summary>
        /// Subtract value from Variable.
        /// </summary>
        /// <param name="value">Value to subtract.</param>
        public void Subtract(float value) => Value -= value;

        /// <summary>
        /// Subtract variable value from Variable.
        /// </summary>
        /// <param name="variable">Variable with value to subtract.</param>
        public void Subtract(AtomBaseVariable<float> variable) => Subtract(variable.Value);

        /// <summary>
        /// Multiply variable by value.
        /// </summary>
        /// <param name="value">Value to multiple by.</param>
        public void MultiplyBy(float value) => Value *= value;

        /// <summary>
        /// Multiply variable by Variable value.
        /// </summary>
        /// <param name="variable">Variable with value to multiple by.</param>
        public void MultiplyBy(AtomBaseVariable<float> variable) => MultiplyBy(variable.Value);

        /// <summary>
        /// Divide Variable by value.
        /// </summary>
        /// <param name="value">Value to divide by.</param>
        public void DivideBy(float value) => Value /= value;

        /// <summary>
        /// Divide Variable by Variable value.
        /// </summary>
        /// <param name="variable">Variable value to divide by.</param>
        public void DivideBy(AtomBaseVariable<float> variable) => DivideBy(variable.Value);
    }
}
