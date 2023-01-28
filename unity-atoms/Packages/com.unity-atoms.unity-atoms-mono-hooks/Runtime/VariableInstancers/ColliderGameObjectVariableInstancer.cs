using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Variable Instancer of type `ColliderGameObject`. Inherits from `AtomVariableInstancer&lt;ColliderGameObjectVariable, ColliderGameObjectPair, ColliderGameObject, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectColliderGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/ColliderGameObject Variable Instancer")]
    public class ColliderGameObjectVariableInstancer : AtomVariableInstancer<
        ColliderGameObjectVariable,
        ColliderGameObjectPair,
        ColliderGameObject,
        ColliderGameObjectEvent,
        ColliderGameObjectPairEvent,
        ColliderGameObjectColliderGameObjectFunction>
    { }
}
