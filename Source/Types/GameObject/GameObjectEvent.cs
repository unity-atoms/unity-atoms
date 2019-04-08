using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/Event", fileName = "GameObjectEvent", order = CreateAssetMenuUtils.Order.EVENT)]
    public sealed class GameObjectEvent : GameEvent<GameObject> { }
}
