using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Int", fileName = "IntList")]
    public sealed class IntList : AtomList<int, IntEvent> { }
}
