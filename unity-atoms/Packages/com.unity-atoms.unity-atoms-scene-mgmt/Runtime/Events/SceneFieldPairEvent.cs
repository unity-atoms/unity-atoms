using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event of type `SceneFieldPair`. Inherits from `AtomEvent&lt;SceneFieldPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SceneFieldPair", fileName = "SceneFieldPairEvent")]
    public sealed class SceneFieldPairEvent : AtomEvent<SceneFieldPair>
    {
    }
}
