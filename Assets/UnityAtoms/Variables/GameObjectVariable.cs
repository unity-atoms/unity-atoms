using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Variables/GameObject")]
    public class GameObjectVariable : ScriptableObjectVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent>
    {
        protected override bool AreEqual(GameObject first, GameObject second)
        {
            return first.GetInstanceID() == second.GetInstanceID();
        }
    }
}