using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UnityEngine.Collider`. Inherits from `AtomEvent&lt;UnityEngine.Collider&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collider", fileName = "ColliderEvent")]
    public sealed class ColliderEvent : AtomEvent<UnityEngine.Collider>
    {
    }
}
