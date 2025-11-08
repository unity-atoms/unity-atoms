using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `CollisionPair`. Inherits from `AtomEvent&lt;CollisionPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CollisionPair", fileName = "CollisionPairEvent")]
    public sealed class CollisionPairEvent : AtomEvent<CollisionPair>
    {
    }
}
