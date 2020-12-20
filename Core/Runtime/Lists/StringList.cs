using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/String", fileName = "StringList")]
    public sealed class StringList : AtomList<string, StringEvent> { }
}
