using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/String/Set Variable", fileName = "SetStringVariableValueAction", order = CreateAssetMenuUtils.Order.SET_VARIABLE)]
    public class SetStringVariableValue : SetVariableValue<string, StringVariable, StringReference, StringEvent, StringStringEvent> { }
}