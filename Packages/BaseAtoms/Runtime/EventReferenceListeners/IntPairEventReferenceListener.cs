using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `IntPair`. Inherits from `AtomEventReferenceListener&lt;IntPair, IntPairEvent, IntPairEventReference, IntPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/IntPair Event Reference Listener")]
    public sealed class IntPairEventReferenceListener : AtomEventReferenceListener<
        IntPair,
        IntPairEvent,
        IntPairEventReference,
        IntPairUnityEvent>
    { }
}
