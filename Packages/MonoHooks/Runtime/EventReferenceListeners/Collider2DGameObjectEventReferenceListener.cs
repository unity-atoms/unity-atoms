using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `Collider2DGameObject`. Inherits from `AtomEventReferenceListener&lt;Collider2DGameObject, Collider2DGameObjectEvent, Collider2DGameObjectEventReference, Collider2DGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collider2DGameObject Event Reference Listener")]
    public sealed class Collider2DGameObjectEventReferenceListener : AtomEventReferenceListener<
        Collider2DGameObject,
        Collider2DGameObjectEvent,
        Collider2DGameObjectEventReference,
        Collider2DGameObjectUnityEvent>
    { }
}
