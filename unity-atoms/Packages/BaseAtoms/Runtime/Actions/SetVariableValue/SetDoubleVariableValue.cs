using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `double`. Inherits from `SetVariableValue&lt;double, DoublePair, DoubleVariable, DoubleConstant, DoubleReference, DoubleEvent, DoublePairEvent, DoubleVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Double", fileName = "SetDoubleVariableValue")]
    public sealed class SetDoubleVariableValue : SetVariableValue<
        double,
        DoublePair,
        DoubleVariable,
        DoubleConstant,
        DoubleReference,
        DoubleEvent,
        DoublePairEvent,
        DoubleDoubleFunction,
        DoubleVariableInstancer>
    { }
}
