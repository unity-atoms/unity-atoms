#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `int`. Inherits from `AtomDrawer&lt;IntConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(IntConstant))]
    public class IntConstantDrawer : VariableDrawer<IntConstant> { }
}
#endif
