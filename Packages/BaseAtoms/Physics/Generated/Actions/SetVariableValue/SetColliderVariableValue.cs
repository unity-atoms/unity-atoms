using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityEngine.Collider`. Inherits from `SetVariableValue&lt;UnityEngine.Collider, ColliderPair, ColliderVariable, ColliderConstant, ColliderReference, ColliderEvent, ColliderPairEvent, ColliderVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collider", fileName = "SetColliderVariableValue")]
    public sealed class SetColliderVariableValue : SetVariableValue<
        UnityEngine.Collider,
        ColliderPair,
        ColliderVariable,
        ColliderConstant,
        ColliderReference,
        ColliderEvent,
        ColliderPairEvent,
        ColliderColliderFunction,
        ColliderVariableInstancer>
    { }
}
