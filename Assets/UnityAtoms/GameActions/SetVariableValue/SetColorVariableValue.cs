using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/Color")]
    public class SetColorVariableValue : SetVariableValue<Color, ColorVariable, ColorReference, ColorEvent, ColorColorEvent> { }
}