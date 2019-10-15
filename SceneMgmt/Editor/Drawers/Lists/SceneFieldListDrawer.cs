#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// List property drawer of type `SceneField`. Inherits from `AtomDrawer&lt;SceneFieldList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SceneFieldList))]
    public class SceneFieldListDrawer : AtomDrawer<SceneFieldList> { }
}
#endif
