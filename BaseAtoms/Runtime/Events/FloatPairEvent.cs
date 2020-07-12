using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `FloatPair`. Inherits from `AtomEvent&lt;FloatPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/FloatPair", fileName = "FloatPairEvent")]
    public sealed class FloatPairEvent : AtomEvent<FloatPair>
    {
    }
}
