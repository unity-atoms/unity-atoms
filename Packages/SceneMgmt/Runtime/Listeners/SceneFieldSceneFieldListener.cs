using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Listener x 2 of type `SceneField`. Inherits from `AtomListener&lt;SceneField, SceneField, SceneFieldSceneFieldAction, SceneFieldSceneFieldEvent, SceneFieldSceneFieldUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SceneField - SceneField")]
    public sealed class SceneFieldSceneFieldListener : AtomListener<
        SceneField,
        SceneField,
        SceneFieldSceneFieldAction,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldUnityEvent>
    { }
}
