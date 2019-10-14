using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Color", fileName = "SetColorVariableValue")]
    public sealed class SetColorVariableValue : SetVariableValue<
        Color,
        ColorVariable,
        ColorReference,
        ColorEvent,
        ColorColorEvent>
    { }
}
