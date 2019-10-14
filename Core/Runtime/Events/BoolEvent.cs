using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Bool", fileName = "BoolEvent")]
    public sealed class BoolEvent : AtomEvent<bool> { }
}
