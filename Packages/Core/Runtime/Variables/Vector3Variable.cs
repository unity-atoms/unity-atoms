using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector3", fileName = "Vector3Variable")]
    public sealed class Vector3Variable : EquatableAtomVariable<Vector3, Vector3Event, Vector3Vector3Event> { }
}
