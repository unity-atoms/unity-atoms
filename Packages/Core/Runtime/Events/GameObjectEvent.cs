using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObject", fileName = "GameObjectEvent")]
    public sealed class GameObjectEvent : AtomEvent<GameObject> { }
}
