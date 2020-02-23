using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `string`. Inherits from `SetVariableValue&lt;string, StringVariable, StringConstant, StringReference, StringEvent, StringStringEvent, StringVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/String", fileName = "SetStringVariableValue")]
    public sealed class SetStringVariableValue : SetVariableValue<
        string,
        StringVariable,
        StringConstant,
        StringReference,
        StringEvent,
        StringStringEvent,
        StringStringFunction,
        StringVariableInstancer>
    { }
}
