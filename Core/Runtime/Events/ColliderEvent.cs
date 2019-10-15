using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Collider`. Inherits from `AtomEvent&lt;Collider&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider", fileName = "ColliderEvent")]
    public sealed class ColliderEvent : AtomEvent<Collider> { }
}
