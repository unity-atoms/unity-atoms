using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `float`. Inherits from `EquatableAtomVariable&lt;float, FloatPair, FloatEvent, FloatPairEvent, FloatFloatFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Float", fileName = "FloatVariable")]
    public sealed class FloatVariable : EquatableAtomVariable<float, FloatPair, FloatEvent, FloatPairEvent, FloatFloatFunction> { }
}
