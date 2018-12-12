using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "Unity Atoms/Collider/Event with GameObject", fileName = "ColliderGameObjectEvent", order = CreateAssetMenuUtils.Order.EVENT_WITH_GO)]
    public class ColliderGameObjectEvent : GameEvent<Collider, GameObject> { }
}