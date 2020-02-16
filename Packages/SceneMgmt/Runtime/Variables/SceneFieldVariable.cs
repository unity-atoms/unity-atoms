using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Variable of type `SceneField`. Inherits from `EquatableAtomVariable&lt;SceneField, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SceneField", fileName = "SceneFieldVariable")]
    public sealed class SceneFieldVariable : EquatableAtomVariable<SceneField, SceneFieldEvent, SceneFieldSceneFieldEvent, SceneFieldSceneFieldFunction> { }
}
