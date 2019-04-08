using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Void/Event with GameObject", fileName = "VoidGameObjectEvent", order = CreateAssetMenuUtils.Order.EVENT_WITH_GO)]
    public sealed class VoidGameObjectEvent : GameEvent<Void, GameObject> { }
}
