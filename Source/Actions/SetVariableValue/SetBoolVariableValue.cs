using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Bool", fileName = "SetBoolVariableValue")]
    public sealed class SetBoolVariableValue : SetVariableValue<
        bool,
        BoolVariable,
        BoolReference,
        BoolEvent,
        BoolBoolEvent>
    { }
}
