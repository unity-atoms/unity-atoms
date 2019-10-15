using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `string`. Inherits from `AtomEvent&lt;string, string&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/String x 2", fileName = "StringStringEvent")]
    public sealed class StringStringEvent : AtomEvent<string, string> { }
}
