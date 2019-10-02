using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [UseIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SceneField", fileName = "SceneFieldVariable")]
    public sealed class SceneFieldVariable : EquatableAtomVariable<SceneField, SceneFieldEvent, SceneFieldSceneFieldEvent> { }
}
