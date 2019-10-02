using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collider", fileName = "SetColliderVariableValue")]
    public sealed class SetColliderVariableValue : SetVariableValue<
        Collider,
        ColliderVariable,
        ColliderReference,
        ColliderEvent,
        ColliderColliderEvent>
    { }
}
