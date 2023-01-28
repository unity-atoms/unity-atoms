using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Vector2`. Inherits from `AtomEvent&lt;Vector2&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector2", fileName = "Vector2Event")]
    public sealed class Vector2Event : AtomEvent<Vector2>
    {
    }
}
