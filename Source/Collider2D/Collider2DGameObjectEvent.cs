using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "Unity Atoms/Collider2D/Event with GameObject", fileName = "Collider2DGameObjectEvent", order = CreateAssetMenuUtils.Order.EVENT_WITH_GO)]
    public class Collider2DGameObjectEvent : GameEvent<Collider2D, GameObject> { }
}