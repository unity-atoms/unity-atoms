using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `bool`. Inherits from `AtomEvent&lt;bool&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Bool", fileName = "BoolEvent")]
    public sealed class BoolEvent : AtomEvent<bool>
    {
    }
}
