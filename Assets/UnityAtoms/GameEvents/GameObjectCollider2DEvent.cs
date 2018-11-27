using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Events/GameObject Collider2D", fileName = "GameObjectCollider2DEvent",
        order                 = 15)]
    public class GameObjectCollider2DEvent : GameEvent<GameObject, Collider2D>
    {
    }
}