using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Collision`. Inherits from `AtomValueList&lt;Collision, CollisionEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Collision", fileName = "CollisionValueList")]
    public sealed class CollisionValueList : AtomValueList<Collision, CollisionEvent> { }
}
