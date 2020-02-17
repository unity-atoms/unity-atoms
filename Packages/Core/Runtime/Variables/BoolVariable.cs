using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `bool`. Inherits from `EquatableAtomVariable&lt;bool, BoolEvent, BoolBoolEvent, BoolBoolFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Bool", fileName = "BoolVariable")]
    public sealed class BoolVariable : EquatableAtomVariable<bool, BoolEvent, BoolBoolEvent, BoolBoolFunction> { }
}
