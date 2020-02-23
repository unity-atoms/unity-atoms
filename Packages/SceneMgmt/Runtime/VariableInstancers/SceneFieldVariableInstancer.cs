using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Variable Instancer of type `SceneField`. Inherits from `AtomVariableInstancer&lt;SceneFieldVariable, SceneField, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SceneField Instancer")]
    public class SceneFieldVariableInstancer : AtomVariableInstancer<SceneFieldVariable, SceneField, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction> { }
}
