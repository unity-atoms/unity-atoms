#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Variable property drawer of type `SceneField`. Inherits from `AtomDrawer&lt;SceneFieldVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SceneFieldVariable))]
    public class SceneFieldVariableDrawer : VariableDrawer<SceneFieldVariable> { }
}
#endif
