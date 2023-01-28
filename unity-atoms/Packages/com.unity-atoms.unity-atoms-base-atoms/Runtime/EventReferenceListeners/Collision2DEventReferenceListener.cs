using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Collision2D`. Inherits from `AtomEventReferenceListener&lt;Collision2D, Collision2DEvent, Collision2DEventReference, Collision2DUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collision2D Event Reference Listener")]
    public sealed class Collision2DEventReferenceListener : AtomEventReferenceListener<
        Collision2D,
        Collision2DEvent,
        Collision2DEventReference,
        Collision2DUnityEvent>
    { }
}
