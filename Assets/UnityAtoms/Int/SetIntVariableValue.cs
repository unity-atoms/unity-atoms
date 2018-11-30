using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Int/Set Variable", fileName = "SetIntVariableValueAction", order = CreateAssetMenuUtils.Order.SET_VARIABLE)]
    public class SetIntVariableValue : SetVariableValue<int, IntVariable, IntReference, IntEvent, IntIntEvent> { }
}