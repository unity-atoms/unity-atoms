using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Listener x 2 of type `SceneField`. Inherits from `AtomX2Listener&lt;SceneField, SceneFieldSceneFieldAction, SceneFieldVariable, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction, SceneFieldVariableInstancer, SceneFieldSceneFieldEventReference, SceneFieldSceneFieldUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SceneField x 2 Listener")]
    public sealed class SceneFieldSceneFieldListener : AtomX2Listener<
        SceneField,
        SceneFieldSceneFieldAction,
        SceneFieldVariable,
        SceneFieldEvent,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer,
        SceneFieldSceneFieldEventReference,
        SceneFieldSceneFieldUnityEvent>
    { }
}
