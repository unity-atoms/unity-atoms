using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Vector3`. Inherits from `EquatableAtomVariable&lt;Vector3, Vector3Event, Vector3Vector3Event, Vector3Vector3Function&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector3", fileName = "Vector3Variable")]
    public sealed class Vector3Variable : EquatableAtomVariable<Vector3, Vector3Event, Vector3Vector3Event, Vector3Vector3Function> { }
}
