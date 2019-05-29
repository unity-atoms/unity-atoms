using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable/Vector2", fileName = "SetVector2VariableValueAction")]
    public sealed class SetVector2VariableValue : SetVariableValue<
        Vector2,
        Vector2Variable,
        Vector2Reference,
        Vector2Event,
        Vector2Vector2Event>
    { }
}
