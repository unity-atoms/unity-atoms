using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Bool/Event", fileName = "BoolEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public sealed class BoolEvent : GameEvent<bool> { }
}
