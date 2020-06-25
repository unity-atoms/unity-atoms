using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `string`. Inherits from `AtomEvent&lt;string&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/String", fileName = "StringEvent")]
    public sealed class StringEvent : AtomEvent<string> { }
}
