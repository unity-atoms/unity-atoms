#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Event x 2 property drawer of type `SceneField`. Inherits from `AtomDrawer&lt;SceneFieldSceneFieldEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SceneFieldSceneFieldEvent))]
    public class SceneFieldSceneFieldEventDrawer : AtomDrawer<SceneFieldSceneFieldEvent> { }
}
#endif
