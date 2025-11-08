using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `CollisionGameObject`. Inherits from `AtomEventReferenceListener&lt;CollisionGameObject, CollisionGameObjectEvent, CollisionGameObjectEventReference, CollisionGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/CollisionGameObject Event Reference Listener")]
    public sealed class CollisionGameObjectEventReferenceListener : AtomEventReferenceListener<
        CollisionGameObject,
        CollisionGameObjectEvent,
        CollisionGameObjectEventReference,
        CollisionGameObjectUnityEvent>
    { }
}
