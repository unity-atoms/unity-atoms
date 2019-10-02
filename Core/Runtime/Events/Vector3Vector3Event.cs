using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector3 x 2", fileName = "Vector3Vector3Event")]
    public sealed class Vector3Vector3Event : AtomEvent<Vector3, Vector3> { }
}
