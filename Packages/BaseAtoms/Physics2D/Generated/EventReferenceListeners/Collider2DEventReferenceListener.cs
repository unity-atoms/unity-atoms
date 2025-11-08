using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityEngine.Collider2D`. Inherits from `AtomEventReferenceListener&lt;UnityEngine.Collider2D, Collider2DEvent, Collider2DEventReference, Collider2DUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2D Event Reference Listener")]
    public sealed class Collider2DEventReferenceListener : AtomEventReferenceListener<
        UnityEngine.Collider2D,
        Collider2DEvent,
        Collider2DEventReference,
        Collider2DUnityEvent>
    { }
}
