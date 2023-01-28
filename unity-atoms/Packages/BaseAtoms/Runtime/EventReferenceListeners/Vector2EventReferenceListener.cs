using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Vector2`. Inherits from `AtomEventReferenceListener&lt;Vector2, Vector2Event, Vector2EventReference, Vector2UnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector2 Event Reference Listener")]
    public sealed class Vector2EventReferenceListener : AtomEventReferenceListener<
        Vector2,
        Vector2Event,
        Vector2EventReference,
        Vector2UnityEvent>
    { }
}
