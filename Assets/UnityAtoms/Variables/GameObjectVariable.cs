using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/GameObject")]
    public class GameObjectVariable : ScriptableObjectVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent>
    {
        protected override bool AreEqual(GameObject first, GameObject second)
        {
            return first.GetInstanceID() == second.GetInstanceID();
        }
    }
}