using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Int", fileName = "IntEvent")]
    public sealed class IntEvent : AtomEvent<int> { }
}
