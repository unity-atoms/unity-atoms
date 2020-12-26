using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Set variable value Action of type `CollisionGameObject`. Inherits from `SetVariableValue&lt;CollisionGameObject, CollisionGameObjectPair, CollisionGameObjectVariable, CollisionGameObjectConstant, CollisionGameObjectReference, CollisionGameObjectEvent, CollisionGameObjectPairEvent, CollisionGameObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/CollisionGameObject", fileName = "SetCollisionGameObjectVariableValue")]
    public sealed class SetCollisionGameObjectVariableValue : SetVariableValue<
        CollisionGameObject,
        CollisionGameObjectPair,
        CollisionGameObjectVariable,
        CollisionGameObjectConstant,
        CollisionGameObjectReference,
        CollisionGameObjectEvent,
        CollisionGameObjectPairEvent,
        CollisionGameObjectCollisionGameObjectFunction,
        CollisionGameObjectVariableInstancer>
    { }
}
