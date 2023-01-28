using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `float`. Inherits from `AtomEventReferenceListener&lt;float, FloatEvent, FloatEventReference, FloatUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Float Event Reference Listener")]
    public sealed class FloatEventReferenceListener : AtomEventReferenceListener<
        float,
        FloatEvent,
        FloatEventReference,
        FloatUnityEvent>
    { }
}
