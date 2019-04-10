using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Collider2D/Event", fileName = "Collider2DEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public sealed class Collider2DEvent : GameEvent<Collider2D> { }
}
