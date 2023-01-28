using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Constant of type `SceneField`. Inherits from `AtomBaseVariable&lt;SceneField&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/SceneField", fileName = "SceneFieldConstant")]
    public sealed class SceneFieldConstant : AtomBaseVariable<SceneField> { }
}
