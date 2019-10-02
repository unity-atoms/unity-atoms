using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Vector3", fileName = "Vector3List")]
    public sealed class Vector3List : AtomList<Vector3, Vector3Event> { }
}
