using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Value List of type `SceneField`. Inherits from `AtomValueList&lt;SceneField, SceneFieldEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/SceneField", fileName = "SceneFieldValueList")]
    public sealed class SceneFieldValueList : AtomValueList<SceneField, SceneFieldEvent> { }
}
