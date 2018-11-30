using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Vector3/Event", fileName = "Vector3Event", order = CreateAssetMenuUtils.Order.EVENT)]
    public class Vector3Event : GameEvent<Vector3> { }
}