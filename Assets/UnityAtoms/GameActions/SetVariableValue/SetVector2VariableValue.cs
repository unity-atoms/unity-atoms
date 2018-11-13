using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/Vector2")]
    public class SetVector2VariableValue : SetVariableValue<Vector2, Vector2Variable, Vector2Reference, Vector2Event, Vector2Vector2Event> { }
}