using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `GameObject`. Inherits from `AtomEvent&lt;GameObject, GameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObject x 2", fileName = "GameObjectGameObjectEvent")]
    public sealed class GameObjectGameObjectEvent : AtomEvent<GameObject, GameObject> { }
}
