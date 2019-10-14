using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Bool", fileName = "BoolList")]
    public sealed class BoolList : AtomList<bool, BoolEvent> { }
}
