using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Vector3/Set Variable", fileName = "SetVector3VariableValueAction", order = CreateAssetMenuUtils.Order.SET_VARIABLE)]
    public class SetVector3VariableValue : SetVariableValue<Vector3, Vector3Variable, Vector3Reference, Vector3Event, Vector3Vector3Event> { }
}