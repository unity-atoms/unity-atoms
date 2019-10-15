using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// List of type `SceneField`. Inherits from `AtomList&lt;SceneField, SceneFieldEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/SceneField", fileName = "SceneFieldList")]
    public sealed class SceneFieldList : AtomList<SceneField, SceneFieldEvent> { }
}
