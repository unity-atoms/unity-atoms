using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `bool`. Inherits from `AtomEvent&lt;bool, bool&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Bool x 2", fileName = "BoolBoolEvent")]
    public sealed class BoolBoolEvent : AtomEvent<bool, bool> { }
}
