using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `GameObjectPair`. Inherits from `AtomEvent&lt;GameObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/GameObjectPair", fileName = "GameObjectPairEvent")]
    public sealed class GameObjectPairEvent : AtomEvent<GameObjectPair>
    {
    }
}
