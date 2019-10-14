using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/String x 2", fileName = "StringStringEvent")]
    public sealed class StringStringEvent : AtomEvent<string, string> { }
}
