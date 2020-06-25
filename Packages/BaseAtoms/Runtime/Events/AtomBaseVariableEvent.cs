using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `AtomBaseVariable`. Inherits from `AtomEvent&lt;AtomBaseVariable&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AtomBaseVariable", fileName = "AtomBaseVariableEvent")]
    public sealed class AtomBaseVariableEvent : AtomEvent<AtomBaseVariable> { }
}
