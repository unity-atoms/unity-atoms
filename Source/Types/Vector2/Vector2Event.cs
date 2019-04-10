using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Vector2/Event", fileName = "Vector2Event", order = CreateAssetMenuUtils.Order.EVENT)]
    public sealed class Vector2Event : GameEvent<Vector2> { }
}
