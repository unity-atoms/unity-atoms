using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collider2D", fileName = "SetCollider2DVariableValue")]
    public sealed class SetCollider2DVariableValue : SetVariableValue<
        Collider2D,
        Collider2DVariable,
        Collider2DReference,
        Collider2DEvent,
        Collider2DCollider2DEvent>
    { }
}
