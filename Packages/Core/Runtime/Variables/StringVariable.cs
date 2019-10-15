using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `string`. Inherits from `EquatableAtomVariable&lt;string, StringEvent, StringStringEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/String", fileName = "StringVariable")]
    public sealed class StringVariable : EquatableAtomVariable<string, StringEvent, StringStringEvent> { }
}
