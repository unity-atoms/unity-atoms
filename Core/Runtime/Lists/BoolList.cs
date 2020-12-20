using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Bool", fileName = "BoolList")]
    public sealed class BoolList : AtomList<bool, BoolEvent> { }
}
