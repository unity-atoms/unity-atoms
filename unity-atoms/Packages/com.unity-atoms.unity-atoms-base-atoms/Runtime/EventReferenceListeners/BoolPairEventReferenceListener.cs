using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `BoolPair`. Inherits from `AtomEventReferenceListener&lt;BoolPair, BoolPairEvent, BoolPairEventReference, BoolPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/BoolPair Event Reference Listener")]
    public sealed class BoolPairEventReferenceListener : AtomEventReferenceListener<
        BoolPair,
        BoolPairEvent,
        BoolPairEventReference,
        BoolPairUnityEvent>
    { }
}
