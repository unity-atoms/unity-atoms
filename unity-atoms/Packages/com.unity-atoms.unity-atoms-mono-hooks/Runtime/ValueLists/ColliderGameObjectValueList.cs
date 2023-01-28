using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Value List of type `ColliderGameObject`. Inherits from `AtomValueList&lt;ColliderGameObject, ColliderGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/ColliderGameObject", fileName = "ColliderGameObjectValueList")]
    public sealed class ColliderGameObjectValueList : AtomValueList<ColliderGameObject, ColliderGameObjectEvent> { }
}
