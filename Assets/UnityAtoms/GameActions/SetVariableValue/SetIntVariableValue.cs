using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/Int",
        fileName              = "SetIntVariableValueAction", order = 0)]
    public class SetIntVariableValue : SetVariableValue<int, IntVariable, IntReference, IntEvent, IntIntEvent>
    {
    }
}