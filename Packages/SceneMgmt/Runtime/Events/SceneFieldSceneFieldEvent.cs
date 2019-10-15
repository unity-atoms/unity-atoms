using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event x 2 of type `SceneField`. Inherits from `AtomEvent&lt;SceneField, SceneField&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SceneField x 2", fileName = "SceneFieldSceneFieldEvent")]
    public sealed class SceneFieldSceneFieldEvent : AtomEvent<SceneField, SceneField> { }
}
