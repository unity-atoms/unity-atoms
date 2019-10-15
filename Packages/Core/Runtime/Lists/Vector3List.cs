using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `Vector3`. Inherits from `AtomList&lt;Vector3, Vector3Event&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Vector3", fileName = "Vector3List")]
    public sealed class Vector3List : AtomList<Vector3, Vector3Event> { }
}
