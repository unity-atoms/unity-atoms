#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Constant property drawer of type `TouchUserInput`. Inherits from `AtomDrawer&lt;TouchUserInputConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TouchUserInputConstant))]
    public class TouchUserInputConstantDrawer : VariableDrawer<TouchUserInputConstant> { }
}
#endif
