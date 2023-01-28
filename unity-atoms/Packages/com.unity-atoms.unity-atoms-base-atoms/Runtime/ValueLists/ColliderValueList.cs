using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Collider`. Inherits from `AtomValueList&lt;Collider, ColliderEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Collider", fileName = "ColliderValueList")]
    public sealed class ColliderValueList : AtomValueList<Collider, ColliderEvent> { }
}
