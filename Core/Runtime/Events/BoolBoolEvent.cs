using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Bool x 2", fileName = "BoolBoolEvent")]
    public sealed class BoolBoolEvent : AtomEvent<bool, bool> { }
}
