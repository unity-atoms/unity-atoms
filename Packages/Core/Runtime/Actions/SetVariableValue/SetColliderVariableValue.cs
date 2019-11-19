using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Collider`. Inherits from `SetVariableValue&lt;Collider, ColliderVariable, ColliderConstant, ColliderReference, ColliderEvent, ColliderColliderEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collider", fileName = "SetColliderVariableValue")]
    public sealed class SetColliderVariableValue : SetVariableValue<
        Collider,
        ColliderVariable,
        ColliderConstant,
        ColliderReference,
        ColliderEvent,
        ColliderColliderEvent,
        ColliderColliderFunction>
    { }
}
