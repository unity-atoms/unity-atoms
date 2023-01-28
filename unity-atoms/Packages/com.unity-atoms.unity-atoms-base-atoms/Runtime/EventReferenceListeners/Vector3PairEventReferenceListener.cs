using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Vector3Pair`. Inherits from `AtomEventReferenceListener&lt;Vector3Pair, Vector3PairEvent, Vector3PairEventReference, Vector3PairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector3Pair Event Reference Listener")]
    public sealed class Vector3PairEventReferenceListener : AtomEventReferenceListener<
        Vector3Pair,
        Vector3PairEvent,
        Vector3PairEventReference,
        Vector3PairUnityEvent>
    { }
}
