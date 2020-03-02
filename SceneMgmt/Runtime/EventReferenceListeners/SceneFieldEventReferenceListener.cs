using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event Reference Listener of type `SceneField`. Inherits from `AtomEventReferenceListener&lt;SceneField, SceneFieldAction, SceneFieldEvent, SceneFieldEventReference, SceneFieldUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/SceneField Event Reference Listener")]
    public sealed class SceneFieldEventReferenceListener : AtomEventReferenceListener<
        SceneField,
        SceneFieldAction,
        SceneFieldEvent,
        SceneFieldEventReference,
        SceneFieldUnityEvent>
    { }
}
