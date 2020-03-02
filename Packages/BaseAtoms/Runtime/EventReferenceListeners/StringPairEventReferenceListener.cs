using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `StringPair`. Inherits from `AtomEventReferenceListener&lt;StringPair, StringPairAction, StringPairEvent, StringPairEventReference, StringPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/StringPair Event Reference Listener")]
    public sealed class StringPairEventReferenceListener : AtomEventReferenceListener<
        StringPair,
        StringPairAction,
        StringPairEvent,
        StringPairEventReference,
        StringPairUnityEvent>
    { }
}
