#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `double`. Inherits from `AtomDrawer&lt;DoubleVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(DoubleVariable))]
    public class DoubleVariableDrawer : VariableDrawer<DoubleVariable> { }
}
#endif
