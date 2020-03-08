using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `GameObjectPair`. Inherits from `AtomEventReferenceListener&lt;GameObjectPair, GameObjectPairEvent, GameObjectPairEventReference, GameObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/GameObjectPair Event Reference Listener")]
    public sealed class GameObjectPairEventReferenceListener : AtomEventReferenceListener<
        GameObjectPair,
        GameObjectPairEvent,
        GameObjectPairEventReference,
        GameObjectPairUnityEvent>
    { }
}
