using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event of type `ColliderGameObject`. Inherits from `AtomEvent&lt;ColliderGameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ColliderGameObject", fileName = "ColliderGameObjectEvent")]
    public sealed class ColliderGameObjectEvent : AtomEvent<ColliderGameObject> { }
}
