#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `double`. Inherits from `AtomDrawer&lt;DoubleConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DoubleConstant))]
    public class DoubleConstantDrawer : VariableDrawer<DoubleConstant> { }
}
#endif
