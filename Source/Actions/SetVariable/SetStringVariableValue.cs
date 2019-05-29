using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable/String", fileName = "SetStringVariableValueAction")]
    public sealed class SetStringVariableValue : SetVariableValue<
        string,
        StringVariable,
        StringReference,
        StringEvent,
        StringStringEvent>
    { }
}
