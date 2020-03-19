using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `string`. Inherits from `SetVariableValue&lt;string, StringPair, StringVariable, StringConstant, StringReference, StringEvent, StringPairEvent, StringVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/String", fileName = "SetStringVariableValue")]
    public sealed class SetStringVariableValue : SetVariableValue<
        string,
        StringPair,
        StringVariable,
        StringConstant,
        StringReference,
        StringEvent,
        StringPairEvent,
        StringStringFunction,
        StringVariableInstancer>
    { }
}
