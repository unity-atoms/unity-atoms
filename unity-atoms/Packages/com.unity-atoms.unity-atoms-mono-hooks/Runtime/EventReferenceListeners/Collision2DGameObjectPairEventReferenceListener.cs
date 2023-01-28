using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `Collision2DGameObjectPair`. Inherits from `AtomEventReferenceListener&lt;Collision2DGameObjectPair, Collision2DGameObjectPairEvent, Collision2DGameObjectPairEventReference, Collision2DGameObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collision2DGameObjectPair Event Reference Listener")]
    public sealed class Collision2DGameObjectPairEventReferenceListener : AtomEventReferenceListener<
        Collision2DGameObjectPair,
        Collision2DGameObjectPairEvent,
        Collision2DGameObjectPairEventReference,
        Collision2DGameObjectPairUnityEvent>
    { }
}
