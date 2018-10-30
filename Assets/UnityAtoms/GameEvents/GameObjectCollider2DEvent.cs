using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "UnityAtoms/Game Events/GameObject Collider2D")]
    public class GameObjectCollider2DEvent : GameEvent<GameObject, Collider2D> { }
}