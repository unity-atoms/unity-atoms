using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "Unity Atoms/Game Events/GameObject Collider2D")]
    public class GameObjectCollider2DEvent : GameEvent<GameObject, Collider2D> { }
}