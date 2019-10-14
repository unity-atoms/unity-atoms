using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SceneField", fileName = "SceneFieldEvent")]
    public sealed class SceneFieldEvent : AtomEvent<SceneField> { }
}
