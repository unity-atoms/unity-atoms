using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `DoublePair`. Inherits from `AtomEventReferenceListener&lt;DoublePair, DoublePairEvent, DoublePairEventReference, DoublePairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/DoublePair Event Reference Listener")]
    public sealed class DoublePairEventReferenceListener : AtomEventReferenceListener<
        DoublePair,
        DoublePairEvent,
        DoublePairEventReference,
        DoublePairUnityEvent>
    { }
}
