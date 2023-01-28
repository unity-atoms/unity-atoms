using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Set variable value Action of type `Collider2DGameObject`. Inherits from `SetVariableValue&lt;Collider2DGameObject, Collider2DGameObjectPair, Collider2DGameObjectVariable, Collider2DGameObjectConstant, Collider2DGameObjectReference, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collider2DGameObject", fileName = "SetCollider2DGameObjectVariableValue")]
    public sealed class SetCollider2DGameObjectVariableValue : SetVariableValue<
        Collider2DGameObject,
        Collider2DGameObjectPair,
        Collider2DGameObjectVariable,
        Collider2DGameObjectConstant,
        Collider2DGameObjectReference,
        Collider2DGameObjectEvent,
        Collider2DGameObjectPairEvent,
        Collider2DGameObjectCollider2DGameObjectFunction,
        Collider2DGameObjectVariableInstancer>
    { }
}
