using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Collider/Event", fileName = "ColliderEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public class ColliderEvent : GameEvent<Collider> { }
}