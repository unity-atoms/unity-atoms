using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `GameObject`. Inherits from `AtomEventReferenceListener&lt;GameObject, GameObjectEvent, GameObjectEventReference, GameObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObject Event Reference Listener")]
    public sealed class GameObjectEventReferenceListener : AtomEventReferenceListener<
        GameObject,
        GameObjectEvent,
        GameObjectEventReference,
        GameObjectUnityEvent>
    { }
}
