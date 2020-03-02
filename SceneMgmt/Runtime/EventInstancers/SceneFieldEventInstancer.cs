using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event Instancer of type `SceneField`. Inherits from `AtomEventInstancer&lt;SceneField, SceneFieldEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SceneField Event Instancer")]
    public class SceneFieldEventInstancer : AtomEventInstancer<SceneField, SceneFieldEvent> { }
}
