using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `ColliderGameObjectPair`. Inherits from `AtomEventReferenceListener&lt;ColliderGameObjectPair, ColliderGameObjectPairAction, ColliderGameObjectPairEvent, ColliderGameObjectPairEventReference, ColliderGameObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/ColliderGameObjectPair Event Reference Listener")]
    public sealed class ColliderGameObjectPairEventReferenceListener : AtomEventReferenceListener<
        ColliderGameObjectPair,
        ColliderGameObjectPairAction,
        ColliderGameObjectPairEvent,
        ColliderGameObjectPairEventReference,
        ColliderGameObjectPairUnityEvent>
    { }
}
