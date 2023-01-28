using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Event Reference Listener of type `Collision2DGameObject`. Inherits from `AtomEventReferenceListener&lt;Collision2DGameObject, Collision2DGameObjectEvent, Collision2DGameObjectEventReference, Collision2DGameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Collision2DGameObject Event Reference Listener")]
    public sealed class Collision2DGameObjectEventReferenceListener : AtomEventReferenceListener<
        Collision2DGameObject,
        Collision2DGameObjectEvent,
        Collision2DGameObjectEventReference,
        Collision2DGameObjectUnityEvent>
    { }
}
