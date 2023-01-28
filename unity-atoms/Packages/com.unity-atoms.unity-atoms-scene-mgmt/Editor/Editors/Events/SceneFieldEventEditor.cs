#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Event property drawer of type `SceneField`. Inherits from `AtomEventEditor&lt;SceneField, SceneFieldEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SceneFieldEvent))]
    public sealed class SceneFieldEventEditor : AtomEventEditor<SceneField, SceneFieldEvent> { }
}
#endif
