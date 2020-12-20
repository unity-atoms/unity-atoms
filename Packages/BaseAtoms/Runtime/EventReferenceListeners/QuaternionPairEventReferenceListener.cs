using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `QuaternionPair`. Inherits from `AtomEventReferenceListener&lt;QuaternionPair, QuaternionPairEvent, QuaternionPairEventReference, QuaternionPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/QuaternionPair Event Reference Listener")]
    public sealed class QuaternionPairEventReferenceListener : AtomEventReferenceListener<
        QuaternionPair,
        QuaternionPairEvent,
        QuaternionPairEventReference,
        QuaternionPairUnityEvent>
    { }
}
