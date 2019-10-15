using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `Vector3`. Inherits from `AtomEvent&lt;Vector3, Vector3&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector3 x 2", fileName = "Vector3Vector3Event")]
    public sealed class Vector3Vector3Event : AtomEvent<Vector3, Vector3> { }
}
