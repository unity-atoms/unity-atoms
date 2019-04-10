using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Float/Event", fileName = "FloatEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public sealed class FloatEvent : GameEvent<float> { }
}
