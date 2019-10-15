using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `Vector2`. Inherits from `AtomEvent&lt;Vector2, Vector2&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector2 x 2", fileName = "Vector2Vector2Event")]
    public sealed class Vector2Vector2Event : AtomEvent<Vector2, Vector2> { }
}
