using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Void`. Inherits from `AtomEventReferenceListener&lt;Void, VoidEvent, VoidBaseEventReference, VoidUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Void Base Event Reference Listener")]
    public sealed class VoidBaseEventReferenceListener : AtomEventReferenceListener<
        Void,
        VoidEvent,
        VoidBaseEventReference,
        VoidUnityEvent>
    { }
}
