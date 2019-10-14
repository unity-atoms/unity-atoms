using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Bool x 2", fileName = "BoolBoolEvent")]
    public sealed class BoolBoolEvent : AtomEvent<bool, bool> { }
}
