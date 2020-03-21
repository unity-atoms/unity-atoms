using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `bool`. Inherits from `EquatableAtomVariable&lt;bool, BoolPair, BoolEvent, BoolPairEvent, BoolBoolFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Bool", fileName = "BoolVariable")]
    public sealed class BoolVariable : EquatableAtomVariable<bool, BoolPair, BoolEvent, BoolPairEvent, BoolBoolFunction> { }
}
