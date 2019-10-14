using UnityEngine;

namespace UnityAtoms.SceneMgmt
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/SceneField", fileName = "SceneFieldList")]
    public sealed class SceneFieldList : AtomList<SceneField, SceneFieldEvent> { }
}
