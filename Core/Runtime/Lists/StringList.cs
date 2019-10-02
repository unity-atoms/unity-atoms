using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/String", fileName = "StringList")]
    public sealed class StringList : AtomList<string, StringEvent> { }
}
