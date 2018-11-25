using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/Vector3",
        fileName              = "SetVector3VariableValueAction", order = 5)]
    public class SetVector3VariableValue : SetVariableValue<Vector3, Vector3Variable, Vector3Reference, Vector3Event,
        Vector3Vector3Event>
    {
    }
}