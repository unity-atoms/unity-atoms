using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Vector3`. Inherits from `AtomEvent&lt;Vector3&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector3", fileName = "Vector3Event")]
    public sealed class Vector3Event : AtomEvent<Vector3>
    {
    }
}
