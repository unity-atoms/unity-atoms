#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Event property drawer of type `SceneField`. Inherits from `AtomDrawer&lt;SceneFieldEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SceneFieldEvent))]
    public class SceneFieldEventDrawer : AtomDrawer<SceneFieldEvent> { }
}
#endif
