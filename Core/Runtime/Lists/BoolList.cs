using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `bool`. Inherits from `AtomList&lt;bool, BoolEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Bool", fileName = "BoolList")]
    public sealed class BoolList : AtomList<bool, BoolEvent> { }
}
