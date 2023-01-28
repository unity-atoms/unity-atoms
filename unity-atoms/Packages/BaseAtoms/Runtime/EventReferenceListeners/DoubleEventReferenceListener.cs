using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `double`. Inherits from `AtomEventReferenceListener&lt;double, DoubleEvent, DoubleEventReference, DoubleUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Double Event Reference Listener")]
    public sealed class DoubleEventReferenceListener : AtomEventReferenceListener<
        double,
        DoubleEvent,
        DoubleEventReference,
        DoubleUnityEvent>
    { }
}
