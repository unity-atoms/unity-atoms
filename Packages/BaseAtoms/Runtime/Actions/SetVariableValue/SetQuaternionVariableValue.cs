using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `Quaternion`. Inherits from `SetVariableValue&lt;Quaternion, QuaternionPair, QuaternionVariable, QuaternionConstant, QuaternionReference, QuaternionEvent, QuaternionPairEvent, QuaternionVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Quaternion", fileName = "SetQuaternionVariableValue")]
    public sealed class SetQuaternionVariableValue : SetVariableValue<
        Quaternion,
        QuaternionPair,
        QuaternionVariable,
        QuaternionConstant,
        QuaternionReference,
        QuaternionEvent,
        QuaternionPairEvent,
        QuaternionQuaternionFunction,
        QuaternionVariableInstancer>
    { }
}
