#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    [CustomPropertyDrawer(typeof(SceneFieldEvent))]
    public class SceneFieldEventDrawer : AtomDrawer<SceneFieldEvent> { }
}
#endif
