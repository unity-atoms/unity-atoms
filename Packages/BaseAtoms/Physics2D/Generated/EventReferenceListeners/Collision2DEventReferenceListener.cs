using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityEngine.Collision2D`. Inherits from `AtomEventReferenceListener&lt;UnityEngine.Collision2D, Collision2DEvent, Collision2DEventReference, Collision2DUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collision2D Event Reference Listener")]
    public sealed class Collision2DEventReferenceListener : AtomEventReferenceListener<
        UnityEngine.Collision2D,
        Collision2DEvent,
        Collision2DEventReference,
        Collision2DUnityEvent>
    { }
}
