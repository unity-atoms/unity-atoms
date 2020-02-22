using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `AtomBaseVariable`. Inherits from `AtomEvent&lt;AtomBaseVariable&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Base Variable", fileName = "BaseVariableEvent")]
    public sealed class AtomBaseVariableEvent : AtomEvent<AtomBaseVariable> { }
}
