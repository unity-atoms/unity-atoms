using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `float`. Inherits from `EquatableAtomVariable&lt;float, FloatEvent, FloatFloatEvent, FloatFloatFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Float", fileName = "FloatVariable")]
    public sealed class FloatVariable : EquatableAtomVariable<float, FloatEvent, FloatFloatEvent, FloatFloatFunction>
    {
        public bool ApplyChange(float amount)
        {
            return SetValue(Value + amount);
        }

        public bool ApplyChange(EquatableAtomVariable<float, FloatEvent, FloatFloatEvent, FloatFloatFunction> amount)
        {
            return SetValue(Value + amount.Value);
        }
    }
}
