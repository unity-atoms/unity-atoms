using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `AtomBaseVariable`. Inherits from `AtomEventReferenceListener&lt;AtomBaseVariable, AtomBaseVariableEvent, AtomBaseVariableBaseEventReference, AtomBaseVariableUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AtomBaseVariable Base Event Reference Listener")]
    public sealed class AtomBaseVariableBaseEventReferenceListener : AtomEventReferenceListener<
        AtomBaseVariable,
        AtomBaseVariableEvent,
        AtomBaseVariableBaseEventReference,
        AtomBaseVariableUnityEvent>
    { }
}
