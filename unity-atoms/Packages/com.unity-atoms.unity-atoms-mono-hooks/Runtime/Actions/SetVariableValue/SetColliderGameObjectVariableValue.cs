using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Set variable value Action of type `ColliderGameObject`. Inherits from `SetVariableValue&lt;ColliderGameObject, ColliderGameObjectPair, ColliderGameObjectVariable, ColliderGameObjectConstant, ColliderGameObjectReference, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/ColliderGameObject", fileName = "SetColliderGameObjectVariableValue")]
    public sealed class SetColliderGameObjectVariableValue : SetVariableValue<
        ColliderGameObject,
        ColliderGameObjectPair,
        ColliderGameObjectVariable,
        ColliderGameObjectConstant,
        ColliderGameObjectReference,
        ColliderGameObjectEvent,
        ColliderGameObjectPairEvent,
        ColliderGameObjectColliderGameObjectFunction,
        ColliderGameObjectVariableInstancer>
    { }
}
