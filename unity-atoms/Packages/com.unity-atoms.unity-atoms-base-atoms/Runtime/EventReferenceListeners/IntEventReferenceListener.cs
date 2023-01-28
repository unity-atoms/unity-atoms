using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `int`. Inherits from `AtomEventReferenceListener&lt;int, IntEvent, IntEventReference, IntUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Int Event Reference Listener")]
    public sealed class IntEventReferenceListener : AtomEventReferenceListener<
        int,
        IntEvent,
        IntEventReference,
        IntUnityEvent>
    { }
}
