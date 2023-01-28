using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event Reference Listener of type `SceneFieldPair`. Inherits from `AtomEventReferenceListener&lt;SceneFieldPair, SceneFieldPairEvent, SceneFieldPairEventReference, SceneFieldPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SceneFieldPair Event Reference Listener")]
    public sealed class SceneFieldPairEventReferenceListener : AtomEventReferenceListener<
        SceneFieldPair,
        SceneFieldPairEvent,
        SceneFieldPairEventReference,
        SceneFieldPairUnityEvent>
    { }
}
