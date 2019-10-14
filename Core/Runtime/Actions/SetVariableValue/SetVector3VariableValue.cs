using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Vector3", fileName = "SetVector3VariableValue")]
    public sealed class SetVector3VariableValue : SetVariableValue<
        Vector3,
        Vector3Variable,
        Vector3Reference,
        Vector3Event,
        Vector3Vector3Event>
    { }
}
