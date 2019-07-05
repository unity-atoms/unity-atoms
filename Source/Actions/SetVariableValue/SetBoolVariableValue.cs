using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable/Bool", fileName = "SetBoolVariableValueAction")]
    public sealed class SetBoolVariableValue : SetVariableValue<
        bool,
        BoolVariable,
        BoolReference,
        BoolEvent,
        BoolBoolEvent>
    { }
}
