using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `StringPair`. Inherits from `AtomEvent&lt;StringPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/StringPair", fileName = "StringPairEvent")]
    public sealed class StringPairEvent : AtomEvent<StringPair>
    {
    }
}
