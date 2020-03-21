using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `float`. Inherits from `AtomVariableInstancer&lt;FloatVariable, FloatPair, float, FloatEvent, FloatPairEvent, FloatFloatFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Float Variable Instancer")]
    public class FloatVariableInstancer : AtomVariableInstancer<
        FloatVariable,
        FloatPair,
        float,
        FloatEvent,
        FloatPairEvent,
        FloatFloatFunction>
    { }
}
