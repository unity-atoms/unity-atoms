using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector3", fileName = "Vector3Event")]
    public sealed class Vector3Event : AtomEvent<Vector3> { }
}
