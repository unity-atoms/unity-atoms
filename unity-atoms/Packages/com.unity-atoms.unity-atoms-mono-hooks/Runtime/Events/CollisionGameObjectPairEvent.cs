using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event of type `CollisionGameObjectPair`. Inherits from `AtomEvent&lt;CollisionGameObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CollisionGameObjectPair", fileName = "CollisionGameObjectPairEvent")]
    public sealed class CollisionGameObjectPairEvent : AtomEvent<CollisionGameObjectPair>
    {
    }
}
