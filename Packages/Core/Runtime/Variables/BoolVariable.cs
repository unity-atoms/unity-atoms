using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Bool", fileName = "BoolVariable")]
    public sealed class BoolVariable : EquatableAtomVariable<bool, BoolEvent, BoolBoolEvent> { }
}
