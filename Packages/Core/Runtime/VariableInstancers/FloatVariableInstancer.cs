using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `float`. Inherits from `AtomVariableInstancer&lt;FloatVariable, float, FloatEvent, FloatFloatEvent, FloatFloatFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Float Instancer")]
    public class FloatVariableInstancer : AtomVariableInstancer<FloatVariable, float, FloatEvent, FloatFloatEvent, FloatFloatFunction> { }
}
