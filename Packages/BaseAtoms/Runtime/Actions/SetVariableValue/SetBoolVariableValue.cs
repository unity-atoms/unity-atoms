using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `bool`. Inherits from `SetVariableValue&lt;bool, BoolPair, BoolVariable, BoolConstant, BoolReference, BoolEvent, BoolPairEvent, BoolVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Bool", fileName = "SetBoolVariableValue")]
    public sealed class SetBoolVariableValue : SetVariableValue<
        bool,
        BoolPair,
        BoolVariable,
        BoolConstant,
        BoolReference,
        BoolEvent,
        BoolPairEvent,
        BoolBoolFunction,
        BoolVariableInstancer>
    { }
}
