using UnityEngine;
using UnityAtoms.BaseAtoms;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Variable Instancer of type `SceneField`. Inherits from `AtomVariableInstancer&lt;SceneFieldVariable, SceneFieldPair, SceneField, SceneFieldEvent, SceneFieldPairEvent, SceneFieldSceneFieldFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SceneField Variable Instancer")]
    public class SceneFieldVariableInstancer : AtomVariableInstancer<
        SceneFieldVariable,
        SceneFieldPair,
        SceneField,
        SceneFieldEvent,
        SceneFieldPairEvent,
        SceneFieldSceneFieldFunction>
    { }
}
