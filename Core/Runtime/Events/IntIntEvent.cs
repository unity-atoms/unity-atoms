using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Int x 2", fileName = "IntIntEvent")]
    public sealed class IntIntEvent : AtomEvent<int, int> { }
}
