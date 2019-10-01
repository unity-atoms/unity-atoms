using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/SceneField", fileName = "SceneFieldList")]
    public sealed class SceneFieldList : AtomList<SceneField, SceneFieldEvent> { }
}
