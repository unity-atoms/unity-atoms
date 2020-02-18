using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `bool`. Inherits from `SetVariableValue&lt;bool, BoolVariable, BoolConstant, BoolReference, BoolEvent, BoolBoolEvent, BoolVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Bool", fileName = "SetBoolVariableValue")]
    public sealed class SetBoolVariableValue : SetVariableValue<
        bool,
        BoolVariable,
        BoolConstant,
        BoolReference,
        BoolEvent,
        BoolBoolEvent,
        BoolBoolFunction,
        BoolVariableInstancer>
    { }
}
