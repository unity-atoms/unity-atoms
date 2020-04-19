using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `string`. Inherits from `AtomValueList&lt;string, StringEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/String", fileName = "StringValueList")]
    public sealed class StringValueList : AtomValueList<string, StringEvent> { }
}
