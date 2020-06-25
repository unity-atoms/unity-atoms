#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Event property drawer of type `SceneFieldPair`. Inherits from `AtomDrawer&lt;SceneFieldPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SceneFieldPairEvent))]
    public class SceneFieldPairEventDrawer : AtomDrawer<SceneFieldPairEvent> { }
}
#endif
