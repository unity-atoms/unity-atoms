using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event of type `CollisionGameObject`. Inherits from `AtomEvent&lt;CollisionGameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/CollisionGameObject", fileName = "CollisionGameObjectEvent")]
    public sealed class CollisionGameObjectEvent : AtomEvent<CollisionGameObject>
    {
    }
}
