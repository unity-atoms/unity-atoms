using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Variable of type `CollisionGameObject`. Inherits from `EquatableAtomVariable&lt;CollisionGameObject, CollisionGameObjectPair, CollisionGameObjectEvent, CollisionGameObjectPairEvent, CollisionGameObjectCollisionGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/CollisionGameObject", fileName = "CollisionGameObjectVariable")]
    public sealed class CollisionGameObjectVariable : EquatableAtomVariable<CollisionGameObject, CollisionGameObjectPair, CollisionGameObjectEvent, CollisionGameObjectPairEvent, CollisionGameObjectCollisionGameObjectFunction>
    {
    }
}
