using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `bool`. Inherits from `AtomValueList&lt;bool, BoolEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Bool", fileName = "BoolValueList")]
    public sealed class BoolValueList : AtomValueList<bool, BoolEvent> { }
}
