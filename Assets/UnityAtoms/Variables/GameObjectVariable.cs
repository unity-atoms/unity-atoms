using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/GameObject", fileName = "GameObjectVariable", order = 6)]
    public class GameObjectVariable : ScriptableObjectVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent>
    {
        protected override bool AreEqual(GameObject first, GameObject second)
        {
            return first.GetInstanceID() == second.GetInstanceID();
        }
    }
}