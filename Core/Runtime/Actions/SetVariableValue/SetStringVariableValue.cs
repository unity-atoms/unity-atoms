using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/String", fileName = "SetStringVariableValue")]
    public sealed class SetStringVariableValue : SetVariableValue<
        string,
        StringVariable,
        StringReference,
        StringEvent,
        StringStringEvent>
    { }
}
