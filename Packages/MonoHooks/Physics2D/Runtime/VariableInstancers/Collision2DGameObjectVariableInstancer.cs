using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Variable Instancer of type `Collision2DGameObject`. Inherits from `AtomVariableInstancer&lt;Collision2DGameObjectVariable, Collision2DGameObjectPair, Collision2DGameObject, Collision2DGameObjectEvent, Collision2DGameObjectPairEvent, Collision2DGameObjectCollision2DGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Collision2DGameObject Variable Instancer")]
    public class Collision2DGameObjectVariableInstancer : AtomVariableInstancer<
        Collision2DGameObjectVariable,
        Collision2DGameObjectPair,
        Collision2DGameObject,
        Collision2DGameObjectEvent,
        Collision2DGameObjectPairEvent,
        Collision2DGameObjectCollision2DGameObjectFunction>
    { }
}
