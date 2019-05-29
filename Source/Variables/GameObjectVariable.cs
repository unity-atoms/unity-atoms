using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/GameObject", fileName = "GameObjectVariable")]
    public sealed class GameObjectVariable : ScriptableObjectVariable<
        GameObject,
        GameObjectEvent,
        GameObjectGameObjectEvent>
    {
        protected override bool AreEqual(GameObject first, GameObject second)
        {
            return (first == null && second == null) || first != null && second != null && first.GetInstanceID() == second.GetInstanceID();
        }
    }
}
