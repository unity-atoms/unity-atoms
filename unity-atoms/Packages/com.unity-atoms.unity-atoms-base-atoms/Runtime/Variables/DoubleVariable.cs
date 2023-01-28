using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `double`. Inherits from `EquatableAtomVariable&lt;double, DoublePair, DoubleEvent, DoublePairEvent, DoubleDoubleFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Double", fileName = "DoubleVariable")]
    public sealed class DoubleVariable : EquatableAtomVariable<double, DoublePair, DoubleEvent, DoublePairEvent, DoubleDoubleFunction>
    {
    }
}
