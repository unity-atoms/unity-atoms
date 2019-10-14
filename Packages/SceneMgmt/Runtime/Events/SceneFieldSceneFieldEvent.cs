using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SceneField x 2", fileName = "SceneFieldSceneFieldEvent")]
    public sealed class SceneFieldSceneFieldEvent : AtomEvent<SceneField, SceneField> { }
}
