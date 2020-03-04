using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `int`. Inherits from `EquatableAtomVariable&lt;int, IntPair, IntEvent, IntPairEvent, IntIntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Int", fileName = "IntVariable")]
    public sealed class IntVariable : EquatableAtomVariable<int, IntPair, IntEvent, IntPairEvent, IntIntFunction> { }
}
