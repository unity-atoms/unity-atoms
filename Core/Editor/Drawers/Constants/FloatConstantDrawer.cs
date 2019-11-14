#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `float`. Inherits from `AtomDrawer&lt;FloatConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(FloatConstant))]
    public class FloatConstantDrawer : VariableDrawer<FloatConstant> { }
}
#endif
