using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `Collider`. Inherits from `AtomEvent&lt;Collider, Collider&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider x 2", fileName = "ColliderColliderEvent")]
    public sealed class ColliderColliderEvent : AtomEvent<Collider, Collider> { }
}
