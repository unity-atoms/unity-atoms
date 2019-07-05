using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable/Vector3", fileName = "SetVector3VariableValueAction")]
    public sealed class SetVector3VariableValue : SetVariableValue<
        Vector3,
        Vector3Variable,
        Vector3Reference,
        Vector3Event,
        Vector3Vector3Event>
    { }
}
