using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `Collider2DGameObjectPair`. Inherits from `AtomEventReferenceListener&lt;Collider2DGameObjectPair, Collider2DGameObjectPairEvent, Collider2DGameObjectPairEventReference, Collider2DGameObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2DGameObjectPair Event Reference Listener")]
    public sealed class Collider2DGameObjectPairEventReferenceListener : AtomEventReferenceListener<
        Collider2DGameObjectPair,
        Collider2DGameObjectPairEvent,
        Collider2DGameObjectPairEventReference,
        Collider2DGameObjectPairUnityEvent>
    { }
}
