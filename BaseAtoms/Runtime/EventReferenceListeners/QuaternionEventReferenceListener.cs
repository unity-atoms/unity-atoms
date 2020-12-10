using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Quaternion`. Inherits from `AtomEventReferenceListener&lt;Quaternion, QuaternionEvent, QuaternionEventReference, QuaternionUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Quaternion Event Reference Listener")]
    public sealed class QuaternionEventReferenceListener : AtomEventReferenceListener<
        Quaternion,
        QuaternionEvent,
        QuaternionEventReference,
        QuaternionUnityEvent>
    { }
}
