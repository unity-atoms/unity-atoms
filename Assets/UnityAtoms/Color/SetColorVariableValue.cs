using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Color/Set Variable", fileName = "SetColorVariableValueAction", order = CreateAssetMenuUtils.Order.SET_VARIABLE)]
    public class SetColorVariableValue : SetVariableValue<Color, ColorVariable, ColorReference, ColorEvent, ColorColorEvent> { }
}