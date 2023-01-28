#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Mobile.Editor
{
    /// <summary>
    /// Variable property drawer of type `TouchUserInput`. Inherits from `AtomDrawer&lt;TouchUserInputVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TouchUserInputVariable))]
    public class TouchUserInputVariableDrawer : VariableDrawer<TouchUserInputVariable> { }
}
#endif
