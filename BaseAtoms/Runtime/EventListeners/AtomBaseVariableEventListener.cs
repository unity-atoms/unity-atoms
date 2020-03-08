using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Listener of type `AtomBaseVariable`. Inherits from `AtomEventListener&lt;AtomBaseVariable, AtomBaseVariableAction, AtomBaseVariableEvent, AtomBaseVariableUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AtomBaseVariable Event Listener")]
    public sealed class AtomBaseVariableEventListener : AtomEventListener<
        AtomBaseVariable,
        AtomBaseVariableAction,
        AtomBaseVariableEvent,
        AtomBaseVariableUnityEvent>
    { }
}
