using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `BoolPair`. Inherits from `AtomEventReferenceListener&lt;BoolPair, BoolPairAction, BoolPairEvent, BoolPairEventReference, BoolPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/BoolPair Event Reference Listener")]
    public sealed class BoolPairEventReferenceListener : AtomEventReferenceListener<
        BoolPair,
        BoolPairAction,
        BoolPairEvent,
        BoolPairEventReference,
        BoolPairUnityEvent>
    { }
}
