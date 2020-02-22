using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `float`. Inherits from `AtomValueList&lt;float, FloatEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Float", fileName = "FloatValueList")]
    public sealed class FloatValueList : AtomValueList<float, FloatEvent> { }
}
