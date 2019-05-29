using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Vector3", fileName = "Vector3List")]
    public sealed class Vector3List : ScriptableObjectList<Vector3, Vector3Event> { }
}
