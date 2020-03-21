using UnityEngine;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Event Reference Listener of type `FSMTransitionData`. Inherits from `AtomEventReferenceListener&lt;FSMTransitionData, FSMTransitionDataEvent, FSMTransitionDataBaseEventReference, FSMTransitionDataUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/FSMTransitionData Base Event Reference Listener")]
    public sealed class FSMTransitionDataBaseEventReferenceListener : AtomEventReferenceListener<
        FSMTransitionData,
        FSMTransitionDataEvent,
        FSMTransitionDataBaseEventReference,
        FSMTransitionDataUnityEvent>
    { }
}
