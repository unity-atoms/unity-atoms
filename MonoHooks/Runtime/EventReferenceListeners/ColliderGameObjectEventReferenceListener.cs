using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `ColliderGameObject`. Inherits from `AtomEventReferenceListener&lt;ColliderGameObject, ColliderGameObjectAction, ColliderGameObjectEvent, ColliderGameObjectEventReference, ColliderGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/ColliderGameObject Event Reference Listener")]
    public sealed class ColliderGameObjectEventReferenceListener : AtomEventReferenceListener<
        ColliderGameObject,
        ColliderGameObjectAction,
        ColliderGameObjectEvent,
        ColliderGameObjectEventReference,
        ColliderGameObjectUnityEvent>
    { }
}
