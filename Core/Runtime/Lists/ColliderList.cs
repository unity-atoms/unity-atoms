using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `Collider`. Inherits from `AtomList&lt;Collider, ColliderEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider", fileName = "ColliderList")]
    public sealed class ColliderList : AtomList<Collider, ColliderEvent> { }
}
