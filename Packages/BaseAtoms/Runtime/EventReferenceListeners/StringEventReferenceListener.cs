using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `string`. Inherits from `AtomEventReferenceListener&lt;string, StringEvent, StringEventReference, StringUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/String Event Reference Listener")]
    public sealed class StringEventReferenceListener : AtomEventReferenceListener<
        string,
        StringEvent,
        StringEventReference,
        StringUnityEvent>
    { }
}
