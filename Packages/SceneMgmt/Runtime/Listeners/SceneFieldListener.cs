using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Listener of type `SceneField`. Inherits from `AtomListener&lt;SceneField, SceneFieldAction, SceneFieldVariable, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction, SceneFieldVariableInstancer, SceneFieldEventReference, SceneFieldUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SceneField Listener")]
    public sealed class SceneFieldListener : AtomListener<
        SceneField,
        SceneFieldAction,
        SceneFieldVariable,
        SceneFieldEvent,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer,
        SceneFieldEventReference,
        SceneFieldUnityEvent>
    { }
}
