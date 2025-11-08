using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Variable Instancer of type `CollisionGameObject`. Inherits from `AtomVariableInstancer&lt;CollisionGameObjectVariable, CollisionGameObjectPair, CollisionGameObject, CollisionGameObjectEvent, CollisionGameObjectPairEvent, CollisionGameObjectCollisionGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/CollisionGameObject Variable Instancer")]
    public class CollisionGameObjectVariableInstancer : AtomVariableInstancer<
        CollisionGameObjectVariable,
        CollisionGameObjectPair,
        CollisionGameObject,
        CollisionGameObjectEvent,
        CollisionGameObjectPairEvent,
        CollisionGameObjectCollisionGameObjectFunction>
    { }
}
