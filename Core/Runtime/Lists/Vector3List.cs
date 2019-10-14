using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Vector3", fileName = "Vector3List")]
    public sealed class Vector3List : AtomList<Vector3, Vector3Event> { }
}
