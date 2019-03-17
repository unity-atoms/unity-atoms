using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Int/Event", fileName = "IntEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public class IntEvent : GameEvent<int> { }
}