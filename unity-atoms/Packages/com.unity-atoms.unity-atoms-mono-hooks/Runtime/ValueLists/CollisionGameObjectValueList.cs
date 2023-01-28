using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Value List of type `CollisionGameObject`. Inherits from `AtomValueList&lt;CollisionGameObject, CollisionGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/CollisionGameObject", fileName = "CollisionGameObjectValueList")]
    public sealed class CollisionGameObjectValueList : AtomValueList<CollisionGameObject, CollisionGameObjectEvent> { }
}
