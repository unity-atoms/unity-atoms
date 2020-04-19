using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Set variable value Action of type `SceneField`. Inherits from `SetVariableValue&lt;SceneField, SceneFieldPair, SceneFieldVariable, SceneFieldConstant, SceneFieldReference, SceneFieldEvent, SceneFieldPairEvent, SceneFieldVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/SceneField", fileName = "SetSceneFieldVariableValue")]
    public sealed class SetSceneFieldVariableValue : SetVariableValue<
        SceneField,
        SceneFieldPair,
        SceneFieldVariable,
        SceneFieldConstant,
        SceneFieldReference,
        SceneFieldEvent,
        SceneFieldPairEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer>
    { }
}
