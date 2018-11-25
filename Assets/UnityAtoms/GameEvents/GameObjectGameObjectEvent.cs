using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Events/GameObject GameObject", fileName = "GameObjectGameObjectEvent",
        order                 = 16)]
    public class GameObjectGameObjectEvent : GameEvent<GameObject, GameObject>
    {
    }
}