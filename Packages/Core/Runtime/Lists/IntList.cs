using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Int", fileName = "IntList")]
    public sealed class IntList : AtomList<int, IntEvent> { }
}
