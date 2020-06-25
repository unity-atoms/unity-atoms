using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `IntPair`. Inherits from `AtomEvent&lt;IntPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/IntPair", fileName = "IntPairEvent")]
    public sealed class IntPairEvent : AtomEvent<IntPair> { }
}
