using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `double`. Inherits from `AtomValueList&lt;double, DoubleEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Double", fileName = "DoubleValueList")]
    public sealed class DoubleValueList : AtomValueList<double, DoubleEvent> { }
}
