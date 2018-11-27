using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/Bool",
        fileName              = "SetBoolVariableValueAction", order = 2)]
    public class SetBoolVariableValue : SetVariableValue<bool, BoolVariable, BoolReference, BoolEvent, BoolBoolEvent>
    {
    }
}