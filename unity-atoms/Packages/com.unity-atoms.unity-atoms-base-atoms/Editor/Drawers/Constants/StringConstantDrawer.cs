#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `string`. Inherits from `AtomDrawer&lt;StringConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(StringConstant))]
    public class StringConstantDrawer : VariableDrawer<StringConstant> { }
}
#endif
