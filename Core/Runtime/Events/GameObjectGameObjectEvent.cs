using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObject x 2", fileName = "GameObjectGameObjectEvent")]
    public sealed class GameObjectGameObjectEvent : AtomEvent<GameObject, GameObject> { }
}
