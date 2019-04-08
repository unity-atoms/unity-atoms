using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Collider/Event", fileName = "ColliderEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public sealed class ColliderEvent : GameEvent<Collider> { }
}
