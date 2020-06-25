using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `ColliderGameObject`. Inherits from `AtomEventReferenceListener&lt;ColliderGameObject, ColliderGameObjectEvent, ColliderGameObjectEventReference, ColliderGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ColliderGameObject Event Reference Listener")]
    public sealed class ColliderGameObjectEventReferenceListener : AtomEventReferenceListener<
        ColliderGameObject,
        ColliderGameObjectEvent,
        ColliderGameObjectEventReference,
        ColliderGameObjectUnityEvent>
    { }
}
