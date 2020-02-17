using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Set variable value Action of type `SceneField`. Inherits from `SetVariableValue&lt;SceneField, SceneFieldVariable, SceneFieldConstant, SceneFieldReference, SceneFieldEvent, SceneFieldSceneFieldEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/SceneField", fileName = "SetSceneFieldVariableValue")]
    public sealed class SetSceneFieldVariableValue : SetVariableValue<
        SceneField,
        SceneFieldVariable,
        SceneFieldConstant,
        SceneFieldReference,
        SceneFieldEvent,
        SceneFieldSceneFieldEvent,
        SceneFieldSceneFieldFunction>
    { }
}
