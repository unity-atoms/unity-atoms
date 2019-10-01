#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    [CustomPropertyDrawer(typeof(SceneFieldSceneFieldEvent))]
    public class SceneFieldSceneFieldEventDrawer : AtomDrawer<SceneFieldSceneFieldEvent> { }
}
#endif
