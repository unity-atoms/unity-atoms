using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `bool`. Inherits from `AtomEventReferenceListener&lt;bool, BoolEvent, BoolEventReference, BoolUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool Event Reference Listener")]
    public sealed class BoolEventReferenceListener : AtomEventReferenceListener<
        bool,
        BoolEvent,
        BoolEventReference,
        BoolUnityEvent>
    { }
}
