using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `string`. Inherits from `AtomList&lt;string, StringEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/String", fileName = "StringList")]
    public sealed class StringList : AtomList<string, StringEvent> { }
}
