using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Vector2`. Inherits from `EquatableAtomVariable&lt;Vector2, Vector2Pair, Vector2Event, Vector2PairEvent, Vector2Vector2Function&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector2", fileName = "Vector2Variable")]
    public sealed class Vector2Variable : EquatableAtomVariable<Vector2, Vector2Pair, Vector2Event, Vector2PairEvent, Vector2Vector2Function>
    {
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
