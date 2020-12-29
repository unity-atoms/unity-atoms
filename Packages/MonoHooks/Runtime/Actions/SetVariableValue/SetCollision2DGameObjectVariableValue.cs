using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Set variable value Action of type `Collision2DGameObject`. Inherits from `SetVariableValue&lt;Collision2DGameObject, Collision2DGameObjectPair, Collision2DGameObjectVariable, Collision2DGameObjectConstant, Collision2DGameObjectReference, Collision2DGameObjectEvent, Collision2DGameObjectPairEvent, Collision2DGameObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Collision2DGameObject", fileName = "SetCollision2DGameObjectVariableValue")]
    public sealed class SetCollision2DGameObjectVariableValue : SetVariableValue<
        Collision2DGameObject,
        Collision2DGameObjectPair,
        Collision2DGameObjectVariable,
        Collision2DGameObjectConstant,
        Collision2DGameObjectReference,
        Collision2DGameObjectEvent,
        Collision2DGameObjectPairEvent,
        Collision2DGameObjectCollision2DGameObjectFunction,
        Collision2DGameObjectVariableInstancer>
    { }
}
