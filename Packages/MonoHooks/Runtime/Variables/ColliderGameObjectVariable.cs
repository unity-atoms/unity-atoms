using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Variable of type `ColliderGameObject`. Inherits from `EquatableAtomVariable&lt;ColliderGameObject, ColliderGameObjectPair, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectColliderGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/ColliderGameObject", fileName = "ColliderGameObjectVariable")]
    public sealed class ColliderGameObjectVariable : EquatableAtomVariable<ColliderGameObject, ColliderGameObjectPair, ColliderGameObjectEvent, ColliderGameObjectPairEvent, ColliderGameObjectColliderGameObjectFunction> { }
}
