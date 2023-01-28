using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event Instancer of type `SceneFieldPair`. Inherits from `AtomEventInstancer&lt;SceneFieldPair, SceneFieldPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SceneFieldPair Event Instancer")]
    public class SceneFieldPairEventInstancer : AtomEventInstancer<SceneFieldPair, SceneFieldPairEvent> { }
}
