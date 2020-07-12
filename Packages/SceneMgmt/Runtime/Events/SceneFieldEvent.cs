using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event of type `SceneField`. Inherits from `AtomEvent&lt;SceneField&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SceneField", fileName = "SceneFieldEvent")]
    public sealed class SceneFieldEvent : AtomEvent<SceneField>
    {
    }
}
