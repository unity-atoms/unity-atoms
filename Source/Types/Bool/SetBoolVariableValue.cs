using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Bool/Set Variable", fileName = "SetBoolVariableValueAction", order = CreateAssetMenuUtils.Order.SET_VARIABLE)]
    public sealed class SetBoolVariableValue : SetVariableValue<
        bool,
        BoolVariable,
        BoolReference,
        BoolEvent,
        BoolBoolEvent>
    { }
}
