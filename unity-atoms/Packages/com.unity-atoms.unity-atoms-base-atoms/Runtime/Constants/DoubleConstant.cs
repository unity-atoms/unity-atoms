using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Constant of type `double`. Inherits from `AtomBaseVariable&lt;double&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/Double", fileName = "DoubleConstant")]
    public sealed class DoubleConstant : AtomBaseVariable<double> { }
}
