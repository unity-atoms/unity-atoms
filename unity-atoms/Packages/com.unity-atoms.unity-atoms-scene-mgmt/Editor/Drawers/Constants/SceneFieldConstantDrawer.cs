#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.SceneMgmt.Editor
{
    /// <summary>
    /// Constant property drawer of type `SceneField`. Inherits from `AtomDrawer&lt;SceneFieldConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SceneFieldConstant))]
    public class SceneFieldConstantDrawer : VariableDrawer<SceneFieldConstant> { }
}
#endif
