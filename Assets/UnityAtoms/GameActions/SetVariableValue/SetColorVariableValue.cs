using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/Color",
        fileName              = "SetColorVariableValueAction", order = 3)]
    public class SetColorVariableValue : SetVariableValue<Color, ColorVariable, ColorReference, ColorEvent, ColorColorEvent>
    {
    }
}