using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Vector2", fileName = "SetVector2VariableValue")]
    public sealed class SetVector2VariableValue : SetVariableValue<
        Vector2,
        Vector2Variable,
        Vector2Reference,
        Vector2Event,
        Vector2Vector2Event>
    { }
}
