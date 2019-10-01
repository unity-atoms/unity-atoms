using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SceneField", fileName = "SceneFieldVariable")]
    public sealed class SceneFieldVariable : EquatableAtomVariable<SceneField, SceneFieldEvent, SceneFieldSceneFieldEvent> { }
}
