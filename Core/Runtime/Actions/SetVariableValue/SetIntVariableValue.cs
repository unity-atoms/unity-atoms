using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `int`. Inherits from `SetVariableValue&lt;int, IntVariable, IntConstant, IntReference, IntEvent, IntIntEvent, IntVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Int", fileName = "SetIntVariableValue")]
    public sealed class SetIntVariableValue : SetVariableValue<
        int,
        IntVariable,
        IntConstant,
        IntReference,
        IntEvent,
        IntIntEvent,
        IntIntFunction,
        IntVariableInstancer>
    { }
}
