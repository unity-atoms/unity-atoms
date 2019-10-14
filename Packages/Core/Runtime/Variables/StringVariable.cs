using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/String", fileName = "StringVariable")]
    public sealed class StringVariable : EquatableAtomVariable<string, StringEvent, StringStringEvent> { }
}
