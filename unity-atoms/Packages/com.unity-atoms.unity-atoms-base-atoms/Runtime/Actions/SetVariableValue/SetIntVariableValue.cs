using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `int`. Inherits from `SetVariableValue&lt;int, IntPair, IntVariable, IntConstant, IntReference, IntEvent, IntPairEvent, IntVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Int", fileName = "SetIntVariableValue")]
    public sealed class SetIntVariableValue : SetVariableValue<
        int,
        IntPair,
        IntVariable,
        IntConstant,
        IntReference,
        IntEvent,
        IntPairEvent,
        IntIntFunction,
        IntVariableInstancer>
    { }
}
