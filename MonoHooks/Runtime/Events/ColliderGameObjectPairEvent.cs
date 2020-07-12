using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event of type `ColliderGameObjectPair`. Inherits from `AtomEvent&lt;ColliderGameObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ColliderGameObjectPair", fileName = "ColliderGameObjectPairEvent")]
    public sealed class ColliderGameObjectPairEvent : AtomEvent<ColliderGameObjectPair>
    {
    }
}
