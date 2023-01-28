using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Vector2Pair`. Inherits from `AtomEvent&lt;Vector2Pair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector2Pair", fileName = "Vector2PairEvent")]
    public sealed class Vector2PairEvent : AtomEvent<Vector2Pair>
    {
    }
}
