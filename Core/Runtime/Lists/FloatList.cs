using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Float", fileName = "FloatList")]
    public sealed class FloatList : AtomList<float, FloatEvent> { }
}
