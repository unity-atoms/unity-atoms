using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/Variable", fileName = "GameObjectVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public class GameObjectVariable : ScriptableObjectVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent>
    {
        protected override bool AreEqual(GameObject first, GameObject second)
        {
            return (first == null && second == null) || first != null && second != null && first.GetInstanceID() == second.GetInstanceID();
        }
    }
}