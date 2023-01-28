#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `bool`. Inherits from `AtomDrawer&lt;BoolConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(BoolConstant))]
    public class BoolConstantDrawer : VariableDrawer<BoolConstant> { }
}
#endif
