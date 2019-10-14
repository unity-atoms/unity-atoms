using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/String", fileName = "StringList")]
    public sealed class StringList : AtomList<string, StringEvent> { }
}
