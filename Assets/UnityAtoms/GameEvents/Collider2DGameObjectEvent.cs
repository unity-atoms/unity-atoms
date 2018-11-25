using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Events/Collider2D GameObject", fileName = "Collider2DGameObjectEvent",
        order                 = 13)]
    public class Collider2DGameObjectEvent : GameEvent<Collider2D, GameObject>
    {
    }
}