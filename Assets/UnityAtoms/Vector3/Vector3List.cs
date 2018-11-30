using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Vector3/List", fileName = "Vector3List", order = CreateAssetMenuUtils.Order.LIST)]
    public class Vector3List : ScriptableObjectList<Vector3, Vector3Event> { }
}