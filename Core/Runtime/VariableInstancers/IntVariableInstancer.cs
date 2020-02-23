using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `int`. Inherits from `AtomVariableInstancer&lt;IntVariable, int, IntEvent, IntIntEvent, IntIntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Int Instancer")]
    public class IntVariableInstancer : AtomVariableInstancer<IntVariable, int, IntEvent, IntIntEvent, IntIntFunction> { }
}
