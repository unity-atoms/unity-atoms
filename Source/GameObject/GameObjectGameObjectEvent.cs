using UnityEngine;

namespace UnityAtoms
{

    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/Event x 2", fileName = "GameObjectGameObjectEvent", order = CreateAssetMenuUtils.Order.EVENTx2)]
    public class GameObjectGameObjectEvent : GameEvent<GameObject, GameObject> { }
}