using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `int`. Inherits from `AtomList&lt;int, IntEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Int", fileName = "IntList")]
    public sealed class IntList : AtomList<int, IntEvent> { }
}
