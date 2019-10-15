using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `float`. Inherits from `AtomList&lt;float, FloatEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Float", fileName = "FloatList")]
    public sealed class FloatList : AtomList<float, FloatEvent> { }
}
