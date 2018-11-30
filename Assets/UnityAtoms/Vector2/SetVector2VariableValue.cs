using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Vector2/Set Variable", fileName = "SetVector2VariableValueAction", order = CreateAssetMenuUtils.Order.SET_VARIABLE)]
    public class SetVector2VariableValue : SetVariableValue<Vector2, Vector2Variable, Vector2Reference, Vector2Event, Vector2Vector2Event> { }
}