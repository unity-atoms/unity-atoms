using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Variable Instancer of type `Collider2DGameObject`. Inherits from `AtomVariableInstancer&lt;Collider2DGameObjectVariable, Collider2DGameObjectPair, Collider2DGameObject, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectCollider2DGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Collider2DGameObject Variable Instancer")]
    public class Collider2DGameObjectVariableInstancer : AtomVariableInstancer<
        Collider2DGameObjectVariable,
        Collider2DGameObjectPair,
        Collider2DGameObject,
        Collider2DGameObjectEvent,
        Collider2DGameObjectPairEvent,
        Collider2DGameObjectCollider2DGameObjectFunction>
    { }
}
