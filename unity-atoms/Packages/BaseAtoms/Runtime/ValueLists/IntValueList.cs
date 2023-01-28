using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `int`. Inherits from `AtomValueList&lt;int, IntEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Int", fileName = "IntValueList")]
    public sealed class IntValueList : AtomValueList<int, IntEvent> { }
}
