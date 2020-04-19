using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `string`. Inherits from `EquatableAtomVariable&lt;string, StringPair, StringEvent, StringPairEvent, StringStringFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/String", fileName = "StringVariable")]
    public class StringVariable : EquatableAtomVariable<string, StringPair, StringEvent, StringPairEvent, StringStringFunction> { }
}
