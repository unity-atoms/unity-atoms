using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/String", fileName = "StringEvent")]
    public sealed class StringEvent : AtomEvent<string> { }
}
