using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `ColliderPair`. Inherits from `AtomEvent&lt;ColliderPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ColliderPair", fileName = "ColliderPairEvent")]
    public sealed class ColliderPairEvent : AtomEvent<ColliderPair>
    {
    }
}
