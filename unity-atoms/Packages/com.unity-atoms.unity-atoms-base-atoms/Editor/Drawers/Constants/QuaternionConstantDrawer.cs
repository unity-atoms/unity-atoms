#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Quaternion`. Inherits from `AtomDrawer&lt;QuaternionConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(QuaternionConstant))]
    public class QuaternionConstantDrawer : VariableDrawer<QuaternionConstant> { }
}
#endif
