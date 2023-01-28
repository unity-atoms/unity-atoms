using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `int`. Inherits from `AtomVariableInstancer&lt;IntVariable, IntPair, int, IntEvent, IntPairEvent, IntIntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Int Variable Instancer")]
    public class IntVariableInstancer : AtomVariableInstancer<
        IntVariable,
        IntPair,
        int,
        IntEvent,
        IntPairEvent,
        IntIntFunction>
    { }
}
