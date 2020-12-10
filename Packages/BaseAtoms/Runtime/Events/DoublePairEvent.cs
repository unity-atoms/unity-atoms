using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `DoublePair`. Inherits from `AtomEvent&lt;DoublePair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/DoublePair", fileName = "DoublePairEvent")]
    public sealed class DoublePairEvent : AtomEvent<DoublePair>
    {
    }
}
