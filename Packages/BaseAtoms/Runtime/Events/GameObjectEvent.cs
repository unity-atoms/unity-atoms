using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `GameObject`. Inherits from `AtomEvent&lt;GameObject&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObject", fileName = "GameObjectEvent")]
    public sealed class GameObjectEvent : AtomEvent<GameObject>
    {
    }
}
