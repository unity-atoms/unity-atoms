#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Event property drawer of type `SceneFieldPair`. Inherits from `AtomEventEditor&lt;SceneFieldPair, SceneFieldPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SceneFieldPairEvent))]
    public sealed class SceneFieldPairEventEditor : AtomEventEditor<SceneFieldPair, SceneFieldPairEvent> { }
}
#endif
