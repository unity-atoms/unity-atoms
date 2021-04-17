using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Collision`. Inherits from `AtomEvent&lt;Collision&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Collision", fileName = "CollisionEvent")]
    public sealed class CollisionEvent : AtomEvent<Collision>
    {
    }
}
