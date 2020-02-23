#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.SceneMgmt;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Event property drawer of type `&lt;SceneField, SceneField&gt;`. Inherits from `AtomEventEditor&lt;SceneField, SceneField, SceneFieldEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SceneFieldSceneFieldEvent))]
    public sealed class SceneFieldSceneFieldEventEditor : AtomEventEditor<SceneField, SceneField, SceneFieldSceneFieldEvent> { }
}
#endif
